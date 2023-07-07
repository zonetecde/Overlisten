using System;
using System.Timers;
using System.Windows;
using System.Windows.Controls;

namespace Overlisten.Extension
{
    internal static class Animation
    {
        internal static void HideAnimation(Grid grid, Grid toMakeAppear = null, Action toDo = null)
        {
            if (grid.Visibility == Visibility.Visible)
            {
                grid.Opacity = 1;

                Timer anim = new Timer(10);
                anim.Elapsed += (sender, e) =>
                {


                    grid.Opacity -= 0.025;
                    if (grid.Opacity <= 0.05)
                    {
                        grid.Visibility = Visibility.Collapsed;
                        grid.Opacity = 1;
                        anim.Stop();

                        if (toMakeAppear != null)
                        {
                            ShowAnimation(toMakeAppear);
                        }
                        if (toDo != null)
                            toDo();
                    }
                };

                anim.Start();
            }
        }

        internal static void ShowAnimation(Grid grid)
        {
            if (grid.Visibility != Visibility.Visible)
            {
                grid.Visibility = Visibility.Visible;
                grid.Opacity = 0;

                Timer anim = new Timer(10);
                anim.Elapsed += (sender, e) =>
                {

                    grid.Opacity += 0.025;
                    if (grid.Opacity >= 0.95)
                    {
                        grid.Opacity = 1;
                        anim.Stop();
                    }
                };

                anim.Start();
            }
        }
    }
}
