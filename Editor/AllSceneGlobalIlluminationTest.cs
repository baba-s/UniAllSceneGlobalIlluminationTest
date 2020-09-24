using NUnit.Framework;
using UnityEditor;

namespace Kogane.Internal
{
	internal sealed class AllSceneGlobalIlluminationTest
	{
		[Category( nameof( Kogane ) )]
		[Test]
		public void グローバルイルミネーションが無効になっているか()
		{
			AllSceneTester.Test( _ => !Lightmapping.TryGetLightingSettings( out var _ ) );
		}
	}
}