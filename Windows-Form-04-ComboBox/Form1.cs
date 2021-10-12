using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Form_04_ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // ComboBox 下拉框：
            // 通过属性items修改下拉选项
            // 通过DropDownStyle修改是否可输入可下拉：
            // DropDown: 可下拉可输入
            // DropDownList: 只能下拉

            MessageBox.Show(Convert.ToString(comboBox1.SelectedValue));
            MessageBox.Show(Convert.ToString(comboBox1.SelectedText));
            //选中的项
            MessageBox.Show(Convert.ToString(comboBox1.SelectedItem));
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 下拉选项每选一个，触发该事件
            
        }

        private void provinceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 选择省，动态添加市
            // 先清空市的数据
            cityComboBox.Items.Clear();
            //cityComboBox.SelectedIndex = -1;
            String province = Convert.ToString(provinceComboBox.SelectedItem);
            if (province == "山东")
            {
                cityComboBox.Items.Add("潍坊");
                cityComboBox.Items.Add("林泽");
                cityComboBox.Items.Add("青岛");
            }
            if (province == "河南")
            {
                cityComboBox.Items.Add("郑州");
                cityComboBox.Items.Add("三门峡");
                cityComboBox.Items.Add("洛阳");
            }
            if (province == "辽宁")
            {
                cityComboBox.Items.Add("沈阳");
                cityComboBox.Items.Add("鞍山");
                cityComboBox.Items.Add("本溪");
            }

        }
    }
}