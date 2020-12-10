using System;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace TORoundedButton
{
	// @interface TORoundedButton : UIContro
	[BaseType (typeof(UIControl), Name="TORoundedButton")]
	interface RoundedButton
	{
		// @property (copy, nonatomic) NSString * _Nonnull text;
		[Export ("text")]
		string Text { get; set; }

		// @property (copy, nonatomic) NSAttributedString * _Nullable attributedText;
		[NullAllowed, Export ("attributedText", ArgumentSemantic.Copy)]
		NSAttributedString AttributedText { get; set; }

		// @property (assign, nonatomic) CGFloat cornerRadius;
		[Export ("cornerRadius")]
		nfloat CornerRadius { get; set; }

		// @property (nonatomic, strong) UIColor * _Nonnull textColor;
		[Export ("textColor", ArgumentSemantic.Strong)]
		UIColor TextColor { get; set; }

		// @property (assign, nonatomic) CGFloat tappedTextAlpha;
		[Export ("tappedTextAlpha")]
		nfloat TappedTextAlpha { get; set; }

		// @property (nonatomic, strong) UIFont * _Nonnull textFont;
		[Export ("textFont", ArgumentSemantic.Strong)]
		UIFont TextFont { get; set; }

		// @property (assign, nonatomic) CGFloat textPointSize;
		[Export ("textPointSize")]
		nfloat TextPointSize { get; set; }

		// @property (assign, nonatomic) CGFloat tappedTintColorBrightnessOffset;
		[Export ("tappedTintColorBrightnessOffset")]
		nfloat TappedTintColorBrightnessOffset { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable tappedTintColor;
		[NullAllowed, Export ("tappedTintColor", ArgumentSemantic.Strong)]
		UIColor TappedTintColor { get; set; }

		// @property (assign, nonatomic) CGFloat tappedButtonScale;
		[Export ("tappedButtonScale")]
		nfloat TappedButtonScale { get; set; }

		// @property (assign, nonatomic) CGFloat tapAnimationDuration;
		[Export ("tapAnimationDuration")]
		nfloat TapAnimationDuration { get; set; }

		// @property (readonly, nonatomic) CGFloat minimumWidth;
		[Export ("minimumWidth")]
		nfloat MinimumWidth { get; }

		// @property (copy, nonatomic) void (^ _Nonnull)(void) tappedHandler;
		[Export ("tappedHandler", ArgumentSemantic.Copy)]
		Action Tapped { get; set; }

		// -(instancetype _Nonnull)initWithText:(NSString * _Nonnull)text;
		[Export ("initWithText:")]
		IntPtr Constructor (string text);
	}
}
