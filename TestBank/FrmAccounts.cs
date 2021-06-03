using AppBL;
using Domain;
using NHibernate;
using Repository.Implementation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TestBank
{
    public partial class FrmAccounts : Form
    {
        private BankConfig _config;
        public FrmAccounts()
        {
            InitializeComponent();
        }

        private void FrmAccounts_Load(object sender, EventArgs e)
        {
            InitForm();
            UpdateList();
        }

        private void listViewCustAcc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewCustAcc.SelectedItems.Count > 0)
            {
                UpdateDetail(this.listViewCustAcc.SelectedItems[0].Group.Name, this.listViewCustAcc.SelectedItems[0].SubItems[0].Text);
            }
            else
            {
                return;
            }
        }

        private void InitForm()
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                try
                {
                    _config = GetAppLogic(session).InitConfig();
                    labelDeptFee.Text = $"Fee {_config.fee_deposite:0.0}%";
                    labelWitdrFee.Text = $"Fee {_config.fee_withdraw:0.0}%";
                    labelTransFee.Text = $"Fee {_config.fee_transfer:0.0}%";
                    comboBoxTransTo.Items.AddRange(GetAppLogic(session).GetAllAccount().Select(x => x.accountNo).ToArray());
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message} | {ex.InnerException}");
                }
                finally
                {
                    session.Close();
                }
            }
        }

        private void ClearDetail()
        {
            textBoxCustID.Text = "";
            textBoxName.Text = "";
            textBoxSurname.Text = "";
            textBoxAccNo.Text = "";
            textBoxBalance.Text = "";

            numericDeptVal.Value = 0;
            textBoxDeptFee.Text = "";
            textBoxDeptTotal.Text = "";

            numericWitdrVal.Value = 0;
            textBoxWitdrFee.Text = "";
            textBoxWitdrTotal.Text = "";

            comboBoxTransTo.SelectedIndex = -1;
            numericTransVal.Value = 0;
            textBoxTransFee.Text = "";
            textBoxTransTotal.Text = "";
        }

        private void UpdateList()
        {
            listViewCustAcc.Items.Clear();
            using (var session = NHibernateHelper.OpenSession())
            {
                try
                {
                    var customers = GetAppLogic(session).GetAllCustomer();
                    foreach(var cust in customers)
                    {
                        listViewCustAcc.Groups.Add(cust.custID, $"{cust.custName} {cust.custSurname} - {cust.custID}");
                        var accounts = GetAppLogic(session).GetAccountByCustID(cust.custID);
                        foreach (var acc in accounts)
                        {
                            var arr = new string[2];
                            arr[0] = acc.accountNo;
                            arr[1] = $"{acc.balance:#,###,##0.00}";
                            var itm = new ListViewItem(arr)
                            {
                                Group = listViewCustAcc.Groups[cust.custID],
                            };
                            listViewCustAcc.Items.Add(itm);
                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"{ex.Message} | {ex.InnerException}");
                }
                finally
                {
                    session.Close();
                }
            }
        }

        private void UpdateDetail(String custID, String accountNo)
        {
            ClearDetail();
            using (var session = NHibernateHelper.OpenSession())
            {
                try
                {
                    var custInfo = GetAppLogic(session).GetCustomerByID(custID);
                    textBoxCustID.Text = custInfo.custID;
                    textBoxName.Text = custInfo.custName;
                    textBoxSurname.Text = custInfo.custSurname;
                    var accountInfo = GetAppLogic(session).GetAccountByID(accountNo);
                    textBoxAccNo.Text = accountInfo.accountNo;
                    textBoxBalance.Text = $"{accountInfo.balance:#,###,##0.00}";

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message} | {ex.InnerException}");
                }
                finally
                {
                    session.Close();
                }
            }
        }

        private AppLogic GetAppLogic(ISession session)
        {
            return new AppLogic(new CustomerRepository(session), new AccountRepository(session), new TransactionRepository(session), new ConfigRepository(session));
        }

        private void numericDeptVal_ValueChanged(object sender, EventArgs e)
        {
            Double deptVal = Convert.ToDouble(numericDeptVal.Value);
            Double feeAmount = deptVal * (_config.fee_deposite.GetValueOrDefault() / 100);
            Double total = deptVal - feeAmount;
            textBoxDeptFee.Text = $"{feeAmount:#,###,##0.00}";
            textBoxDeptTotal.Text = $"{total:#,###,##0.00}";
        }

        private void numericWitdrVal_ValueChanged(object sender, EventArgs e)
        {
            Double witdrVal = Convert.ToDouble(numericWitdrVal.Value);
            Double feeAmount = witdrVal * (_config.fee_withdraw.GetValueOrDefault() / 100); ;
            Double total = witdrVal - feeAmount;
            textBoxWitdrFee.Text = $"{feeAmount:#,###,##0.00}";
            textBoxWitdrTotal.Text = $"{total:#,###,##0.00}";
        }

        private void numericTransVal_ValueChanged(object sender, EventArgs e)
        {
            Double transVal = Convert.ToDouble(numericTransVal.Value);
            Double feeAmount = transVal * (_config.fee_transfer.GetValueOrDefault() / 100); ;
            Double total = transVal - feeAmount;
            textBoxTransFee.Text = $"{feeAmount:#,###,##0.00}";
            textBoxTransTotal.Text = $"{total:#,###,##0.00}";
        }

        private void buttonDeposite_Click(object sender, EventArgs e)
        {
            using (var session = NHibernateHelper.OpenSession())
            using (var transaction = session.BeginTransaction())
            {
                try
                {
                    GetAppLogic(session).DepositeAccount(textBoxAccNo.Text, Convert.ToDouble(numericDeptVal.Value));
                    transaction.Commit();
                    UpdateList();
                    UpdateDetail(textBoxCustID.Text, textBoxAccNo.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message} | {ex.InnerException}");
                }
                finally
                {
                    session.Close();
                }
            }
        }

        private void buttonWitdr_Click(object sender, EventArgs e)
        {
            using (var session = NHibernateHelper.OpenSession())
            using (var transaction = session.BeginTransaction())
            {
                try
                {
                    GetAppLogic(session).WithDrawAccount(textBoxAccNo.Text, Convert.ToDouble(numericWitdrVal.Value));
                    transaction.Commit();
                    UpdateList();
                    UpdateDetail(textBoxCustID.Text, textBoxAccNo.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message} | {ex.InnerException}");
                }
                finally
                {
                    session.Close();
                }
            }
        }

        private void buttonTrans_Click(object sender, EventArgs e)
        {
            using (var session = NHibernateHelper.OpenSession())
            using (var transaction = session.BeginTransaction())
            {
                try
                {
                    GetAppLogic(session).TransferAccount(textBoxAccNo.Text, comboBoxTransTo.SelectedItem.ToString(), Convert.ToDouble(numericTransVal.Value));
                    transaction.Commit();
                    UpdateList();
                    UpdateDetail(textBoxCustID.Text, textBoxAccNo.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message} | {ex.InnerException}");
                }
                finally
                {
                    session.Close();
                }
            }
        }
    }
}
