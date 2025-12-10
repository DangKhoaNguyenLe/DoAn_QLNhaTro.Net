using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public class MenuAnimator
    {
        private FlowLayoutPanel panel;
        private Timer timer;
        private int expandedHeight;
        private int collapsedHeight;
        private bool expanded = false;
        private int speed = 10;

        public MenuAnimator(FlowLayoutPanel pnl, Timer tmr, int collapsedHeight = 60)
        {
            panel = pnl;
            timer = tmr;
            this.collapsedHeight = collapsedHeight;

            // Tính tự động chiều cao mở rộng
            expandedHeight = pnl.Controls.OfType<Control>().Sum(c => c.Height) + collapsedHeight;

            timer.Interval = 15;
            timer.Tick += Animate;
        }

        public void Toggle() => timer.Start();

        private void Animate(object sender, EventArgs e)
        {
            if (!expanded)
            {
                panel.Height += speed;
                if (panel.Height >= expandedHeight)
                {
                    panel.Height = expandedHeight;
                    expanded = true;
                    timer.Stop();
                }
            }
            else
            {
                panel.Height -= speed;
                if (panel.Height <= collapsedHeight)
                {
                    panel.Height = collapsedHeight;
                    expanded = false;
                    timer.Stop();
                }
            }
        }
    }

}
