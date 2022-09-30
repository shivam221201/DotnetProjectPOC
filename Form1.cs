//using Microsoft.Toolkit.Forms.UI.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace GoogleMaps_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataTable countries;
        DataTable cities;
        TreeNode Node, subNode;
        public delegate void Add(TreeNode i);

        public delegate void performeSteps(int value);
        public void performeStep(int value)
        {
            //status progress bar  :
            pb_state.Value = value;
            //status label  :
            lbl_state.Text = value + "%";
        }

        void LoadData()
        {
            try
            {
                countries = new Provider().Load("countries");
                int count = countries.Rows.Count, current = 0;
                foreach (DataRow country in countries.Rows)
                {
                    Node = new TreeNode(country["english"].ToString());
                    cities = new Provider().Loading(string.Format("select city from cities where country_id = {0}",
                                    int.Parse(country["ID"].ToString())));
                    foreach (DataRow city in cities.Rows)
                    {
                        subNode = new TreeNode(city["city"].ToString());
                        Node.Nodes.Add(subNode);
                        Node.ImageIndex = 0;
                        subNode.ImageIndex = 1;
                    }
                    treeView1.Invoke(new Add(Add1), new object[] { Node });
                    current++;
                    Strip_State.Invoke(new performeSteps(performeStep), new object[] { (current * 100) / count });
                }
                treeView1.NodeMouseClick += new TreeNodeMouseClickEventHandler(TreeClick);
                treeView1.Update();
                countries = null;
                cities = null;

            }
            catch (Exception x)
            {
                string h = x.Message;
            }
        }

        public void Add1(TreeNode i)
        {
            treeView1.Nodes.Add(i);
        }

        public void TreeClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            try { 
            DataTable dt = new Provider().Loading("select c.lat , c.lon , co.english , c.city from cities as c " +
                                                  "inner join countries as co " +
                                                  "on c.country_id = co.id " +
                                                    "and c.city = '" + e.Node.Text + "'");
                if (dt.Rows.Count > 0)
                {
                    string marker = "marker.png";
                    string image = "image.png";
                    string path = Application.StartupPath + "\\map.html";
                    this.Text = path;
                    string filename = Application.StartupPath + "\\mymap.html";
                    DataRow r = dt.Rows[0];
                    variables.replace(filename, r["lat"].ToString(), r["lon"].ToString(),
                                        r["english"].ToString(), r["city"].ToString(),
                                        marker, image, path);
                   // this.webBrowser1.Url = new Uri(path);

                   // this.webView21.Source = new Uri(path);
                    this.webView21.NavigateToString(path);
 
                } 
            }
            catch (Exception ex)
            {

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!BKProgress.IsBusy)
                BKProgress.RunWorkerAsync();
        }

        private void BKProgress_DoWork(object sender, DoWorkEventArgs e)
        {
            LoadData();
        }

        private void webView21_Click(object sender, EventArgs e)
        {

        }

        private void BKProgress_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lbl_state.Text = "Done!";
        }
    }
}
