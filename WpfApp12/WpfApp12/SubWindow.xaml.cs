using System;
using System.Windows;

namespace WpfApp12
{
    public partial class SubWindow : Window
    {

        public Delegate UpdateActor;

        public SubWindow()
        {
            InitializeComponent();
        }

        // 저장 버튼 클릭
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (rdoInner.IsChecked == false && rdoOutside.IsChecked == false)
            {
                MessageBox.Show("내근 또는 외근을 선택하세요.", "항목선택");
                return;
            }
            DutyType dutyType = (rdoInner.IsChecked == true) ? DutyType.Inner : DutyType.OutSide;
            MainWindow.duties.Add(new Duty(txtDutyName.Text, dutyType));
            UpdateActor.DynamicInvoke(dutyType);
            MessageBox.Show("저장OK!", "저장확인");
            this.Close();
        }
    }
}