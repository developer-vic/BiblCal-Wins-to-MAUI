using Microsoft.Extensions.Logging;
using Microsoft.Maui.Handlers;

namespace BiblCalMaui;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

#if IOS || MACCATALYST
		// Remove border from all Entry controls on iOS and MacCatalyst
		EntryHandler.Mapper.AppendToMapping("Borderless", (handler, view) =>
		{
			if (handler.PlatformView is UIKit.UITextField textField)
			{
				textField.BorderStyle = UIKit.UITextBorderStyle.None;
				textField.Layer.BorderWidth = 0;
			}
		});

		// Remove border from all Picker controls on iOS and MacCatalyst
		PickerHandler.Mapper.AppendToMapping("Borderless", (handler, view) =>
		{
			// Picker uses UITextField as its platform view on iOS/MacCatalyst
			if (handler.PlatformView is UIKit.UITextField textField)
			{
				textField.BorderStyle = UIKit.UITextBorderStyle.None;
				textField.Layer.BorderWidth = 0;
			}
		});
#endif

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
