using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;
using Entity;

namespace PicoPlacaApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnCheckPermission_Click(object sender, EventArgs e)
        {
            PermissionCarOnRoadLg permission = new PermissionCarOnRoadLg();
            CarOnRoad carOnRoad = new CarOnRoad(txtLicensePlateNumber.Text, txtDate.Text, txtTime.Text);

            bool permissionOnRoad = permission.HasCarPermissionOnRoad(carOnRoad);

            if (permissionOnRoad)
                MessageBox.Show("Car has permission on road");
            else 
                MessageBox.Show("Car has not permission on road");
        }

        public void CheckPermission(string licensePlateNumber, string date, string time ) {
            PermissionCarOnRoadLg permission = new PermissionCarOnRoadLg();
            CarOnRoad carOnRoad = new CarOnRoad(licensePlateNumber, date, time);

            bool permissionOnRoad = permission.HasCarPermissionOnRoad(carOnRoad);

            if (permissionOnRoad)
                Console.WriteLine("Car has permission on road");
            else
                Console.WriteLine("Car has not permission on road");
        }
    }
}
