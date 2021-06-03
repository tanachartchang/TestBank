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
using System.Windows.Forms;

namespace TestBank
{
    public partial class FrmAccounts : Form
    {
        public FrmAccounts()
        {
            InitializeComponent();
        }

        private void FrmAccounts_Load(object sender, EventArgs e)
        {
            InitForm();
            UpdateList();
        }

        private void listViewCust_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                UpdateAddrList(listViewCustAcc.SelectedItems[0].Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }

        private void InitForm()
        {
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

        private void UpdateAddrList(String custID)
        {
            //listViewAddr.Items.Clear();
            //List<BankAccount> accounts = new List<BankAccount>();
            //using (var session = NHibernateHelper.OpenSession())
            //{
            //    try
            //    {
            //        accounts = GetAppLogic(session).GetAccountByCustID(custID);
            //        foreach (var acc in accounts)
            //        {
            //            string[] arr = new string[2];
            //            ListViewItem itm;
            //            arr[0] = acc.accountNo;
            //            arr[1] = $"{acc.balance:#,###,##0.00}";
            //            itm = new ListViewItem(arr);
            //            listViewAddr.Items.Add(itm);
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show($"{ex.Message} | {ex.InnerException}");
            //    }
            //    finally
            //    {
            //        session.Close();
            //    }
            //}
        }

        private AppLogic GetAppLogic(ISession session)
        {
            return new AppLogic(new CustomerRepository(session), new AccountRepository(session), new TransactionRepository(session), new ConfigRepository(session));
        }
    }
}
