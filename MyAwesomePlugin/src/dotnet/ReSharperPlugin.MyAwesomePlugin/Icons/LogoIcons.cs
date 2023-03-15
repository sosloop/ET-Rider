namespace ReSharperPlugin.ETPlugin.Icons
{
    public sealed class LogoIcons
    {
        [global::JetBrains.Application.Icons.CompiledIconsCs.CompiledIconCsAttribute()]
		public sealed class ET : global::JetBrains.Application.Icons.CompiledIconsCs.CompiledIconCsClass
		{
			
			/// <inheritdoc cref="Unity">identifier class</inheritdoc>
			public static global::JetBrains.UI.Icons.IconId Id = new global::JetBrains.Application.Icons.CompiledIconsCs.CompiledIconCsId(typeof(ET));
			
			/// <summary>Loads the image for Themed Icon Unity theme aspect Color.</summary>
			public global::JetBrains.Util.Icons.TiImage Load_Color()
			{
				return global::JetBrains.Util.Icons.TiImageConverter.FromTiSvg(@"<svg ti:v='1' width='16' height='16' viewBox='0,0,16,16' xmlns='http://www.w3.org/2000/svg' xmlns:ti='urn:schemas-jetbrains-com:tisvg'><g><linearGradient id='F0' x1='0.5' y1='0.0101875' x2='0.5' y2='1.0046875'><stop offset='0' stop-color='#226E6E'/><stop offset='1' stop-color='#12344D'/></linearGradient><path d='M7.732,16L8.268,16L14.989,12.119L15,12.125L15,3.887L8.268,0L7.732,0L1,3.887L1,12.125L1.011,12.119L7.732,16ZM7.732,16' fill='url(#F0)'/><linearGradient id='F1' x1='0.5' y1='0' x2='0.5' y2='1'><stop offset='0' stop-color='#DDFFFE'/><stop offset='1' stop-color='#B4D1E3'/></linearGradient><path d='M14,10.376L14,4.464L9,1.577L9,3.887L11.025,5.056L8,6.839L4.975,5.056L7,3.887L7,1.577L2,4.464L2,10.376L4,9.197L4,6.803L7,8.571L7,12.113L4.975,10.944L2.995,12.11L8,15L13.005,12.11L11.025,10.944L9,12.113L9,8.571L12,6.803L12,9.197L14,10.376ZM14,10.376' fill='url(#F1)'/></g></svg>");
			}
			
			/// <summary>Loads the image for Themed Icon Unity theme aspect Gray.</summary>
			public global::JetBrains.Util.Icons.TiImage Load_Gray()
			{
				return global::JetBrains.Util.Icons.TiImageConverter.FromTiSvg(@"<svg ti:v='1' width='16' height='16' viewBox='0,0,16,16' xmlns='http://www.w3.org/2000/svg' xmlns:ti='urn:schemas-jetbrains-com:tisvg'><g><path d='M7.732,16L8.268,16L14.989,12.119L15,12.125L15,3.887L8.268,0L7.732,0L1,3.887L1,12.125L1.011,12.119L7.732,16ZM7.732,16' fill='#F4F4F4'/><path d='M14,10.376L14,4.464L9,1.577L9,3.887L11.025,5.056L8,6.839L4.975,5.056L7,3.887L7,1.577L2,4.464L2,10.376L4,9.197L4,6.803L7,8.571L7,12.113L4.975,10.944L2.995,12.11L8,15L13.005,12.11L11.025,10.944L9,12.113L9,8.571L12,6.803L12,9.197L14,10.376ZM14,10.376' fill='#323232'/></g></svg>");
			}
			
			/// <summary>Loads the image for Themed Icon Unity theme aspect GrayDark.</summary>
			public global::JetBrains.Util.Icons.TiImage Load_GrayDark()
			{
				return global::JetBrains.Util.Icons.TiImageConverter.FromTiSvg(@"<svg ti:v='1' width='16' height='16' viewBox='0,0,16,16' xmlns='http://www.w3.org/2000/svg' xmlns:ti='urn:schemas-jetbrains-com:tisvg'><g><path d='M7.732,16L8.268,16L14.989,12.119L15,12.125L15,3.887L8.268,0L7.732,0L1,3.887L1,12.125L1.011,12.119L7.732,16ZM7.732,16' fill='#252525'/><path d='M14,10.376L14,4.464L9,1.577L9,3.887L11.025,5.056L8,6.839L4.975,5.056L7,3.887L7,1.577L2,4.464L2,10.376L4,9.197L4,6.803L7,8.571L7,12.113L4.975,10.944L2.995,12.11L8,15L13.005,12.11L11.025,10.944L9,12.113L9,8.571L12,6.803L12,9.197L14,10.376ZM14,10.376' fill='#C4C4C4'/></g></svg>");
			}
			
			/// <summary>Returns the set of theme images for Themed Icon Unity.</summary>
			public override global::JetBrains.Application.Icons.CompiledIconsCs.CompiledIconCsIdOwner.ThemedIconThemeImage[] GetThemeImages()
			{
				return new global::JetBrains.Application.Icons.CompiledIconsCs.CompiledIconCsIdOwner.ThemedIconThemeImage[] {
						new global::JetBrains.Application.Icons.CompiledIconsCs.CompiledIconCsIdOwner.ThemedIconThemeImage("Color", new global::JetBrains.Application.Icons.CompiledIconsCs.CompiledIconCsIdOwner.LoadImageDelegate(this.Load_Color)),
						new global::JetBrains.Application.Icons.CompiledIconsCs.CompiledIconCsIdOwner.ThemedIconThemeImage("Gray", new global::JetBrains.Application.Icons.CompiledIconsCs.CompiledIconCsIdOwner.LoadImageDelegate(this.Load_Gray)),
						new global::JetBrains.Application.Icons.CompiledIconsCs.CompiledIconCsIdOwner.ThemedIconThemeImage("GrayDark", new global::JetBrains.Application.Icons.CompiledIconsCs.CompiledIconCsIdOwner.LoadImageDelegate(this.Load_GrayDark))};
			}
		}
    }
}