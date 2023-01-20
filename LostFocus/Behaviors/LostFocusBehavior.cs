using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Input;
using Microsoft.Xaml.Behaviors;

namespace LostFocus.Behaviors
{
    public class LostFocusBehavior : Behavior<Window>
    {
        public ICommand Command
        {
            get { return (ICommand)GetValue(CommandProperty); }
            set { SetValue(CommandProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CommandProperty =
            DependencyProperty.Register(nameof(Command), typeof(ICommand), typeof(LostFocusBehavior), new PropertyMetadata(null));

        protected override void OnAttached()
        {
            AssociatedObject.LostFocus += KeyboardLostFocusBehavior;
        }

        protected override void OnDetaching()
        {
            AssociatedObject.LostFocus -= KeyboardLostFocusBehavior;
        }

        private void KeyboardLostFocusBehavior(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("asdf");

        }

    }
}
