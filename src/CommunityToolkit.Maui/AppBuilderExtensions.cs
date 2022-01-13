﻿using CommunityToolkit.Maui.Core;
using CommunityToolkit.Maui.Views;

namespace CommunityToolkit.Maui;

/// <summary>
/// Extensions for MauiAppBuilder
/// </summary>
public static class AppBuilderExtensions
{
	/// <summary>
	/// Initializes the .NET Maui Community Toolkit Library
	/// </summary>
	/// <param name="builder"><see cref="MauiAppBuilder"/> generated by <see cref="MauiApp"/> </param>
	/// <returns><see cref="MauiAppBuilder"/> initialized for <see cref="CommunityToolkit.Maui"/></returns>
	public static MauiAppBuilder UseMauiCommunityToolkit(this MauiAppBuilder builder)
	{
		builder.ConfigureMauiHandlers(h =>
		{
#if __ANDROID__ || __IOS__ || __MACCATALYST__
		   h.AddHandler(typeof(BasePopup), typeof(PopupViewHandler));
		   h.AddHandler(typeof(Popup), typeof(PopupViewHandler));
#endif
		});

		return builder.UseMauiCommunityToolkitCore();
	}
}