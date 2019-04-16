using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;

namespace firstIOSApp
{
    public class MyViewController : UIViewController
    {
        public MyViewController()
        {
        }
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            this.View.BackgroundColor = UIColor.Blue;
            var totalAmount = new UITextField()
            {
                Frame = new CoreGraphics.CGRect(20, 38, View.Bounds.Width - 40, 35),
                KeyboardType = UIKeyboardType.DecimalPad,
                BorderStyle = UITextBorderStyle.RoundedRect,
                Placeholder = "Pon lo que te salga del nardo en numero",
            };

            var calculateButton = new UIButton()
            {
                Frame = new CoreGraphics.CGRect(20, 71, View.Bounds.Width - 40, 45),
                BackgroundColor = UIColor.Red,

            };

            calculateButton.SetTitle("Dale", UIControlState.Normal);

            var resultLabel = new UILabel()
            {
                Frame = new CoreGraphics.CGRect(20, 124, View.Bounds.Width - 40, 40),
                BackgroundColor = UIColor.DarkGray,
                TextAlignment = UITextAlignment.Center,
                Font = UIFont.SystemFontOfSize(20),
                Text = "Propinaca de $0"
            };
            View.AddSubviews(totalAmount, calculateButton, resultLabel);
            calculateButton.TouchUpInside += (s,e) => {
                double value = 0;
                Double.TryParse(totalAmount.Text, out value);
                resultLabel.Text = string.Format("La propinaca es {0:C}", value * 0.2);
                totalAmount.ResignFirstResponder();
            };
        }
    }
  
}