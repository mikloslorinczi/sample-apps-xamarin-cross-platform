using System;
using AppKit;
using Foundation;

namespace Multiplatform.Mac
{
	public partial class ViewController : NSViewController
	{
		int count = 1;

		public ViewController(IntPtr handle) : base(handle)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
		}

		partial void Action(Foundation.NSObject sender)
		{
			var title = string.Format("{0} clicks!", count++);
			Button.Title = title;
		}

		public override NSObject RepresentedObject
		{
			get
			{
				return base.RepresentedObject;
			}
			set
			{
				base.RepresentedObject = value;
			}
		}
	}
}
