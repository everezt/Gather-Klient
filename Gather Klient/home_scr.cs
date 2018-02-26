using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gather_Klient
{
    public partial class home_scr : Form
    {
        delegate void string_delegate(string text);
        delegate void list_string_delegate(List<string> list);
        custom_font c_font = new custom_font();

        public home_scr()
        {
            InitializeComponent();

            // Set custom fonts
            users_online.Font = c_font.load_font(20, 1, true);
            online_users_list.Font = c_font.load_font(12, 0, true);
        }

        public void update_clients_online_numer(string amount)
        {
            if (this.InvokeRequired)
            {
                string_delegate d = new string_delegate(update_clients_online_numer);
                this.Invoke(d, new object[] { amount });
            }
            else
            {
                this.users_online.Text = "(" + amount + ")";
            }
            
        }

        public void update_clients_list(List<string> usernames)
        {
            if (this.InvokeRequired)
            {
                list_string_delegate d = new list_string_delegate(update_clients_list);
                this.Invoke(d, new object[] { usernames });
            }
            else
            {
                if (online_users_list.Items.Count == 0)
                {
                    for (int i = 0; i <= usernames.Count - 1; i++)
                    {
                        if (usernames[i] != "")
                        {
                            online_users_list.Items.Add(usernames[i]);
                        }
                    }
                }
                else
                {

                    // add users
                    for(int i = 0; i <= usernames.Count -1; i++)
                    {
                        bool found_user = false;

                        for (int j = 0; j <= online_users_list.Items.Count -1; j++)
                        {
                            if (online_users_list.Items[j].ToString().Trim() == usernames[i].ToString().Trim())
                            {
                                found_user = true;
                                continue;
                            }
                        }

                        if (!found_user)
                        {
                            if (usernames[i] != "")
                                online_users_list.Items.Add(usernames[i]);
                        }
                    }


                    // delete users

                    for (int i = 0; i <= online_users_list.Items.Count - 1; i++)
                    {
                        bool found_user = false;
                        for (int j = 0; j <= usernames.Count - 1; j++)
                        {
                            if (online_users_list.Items[i].ToString().Trim() == usernames[j].ToString().Trim())
                            {
                                found_user = true;
                                continue;
                            }

                        }

                        if (!found_user)
                        {
                            online_users_list.Items.RemoveAt(i);
                        }
                    }

                }
            }
        }      
    }
}
