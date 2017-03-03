#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=24)]
	public partial struct FBlendSample
	{
		[FieldOffset(8)]
		public FVector SampleValue;
		[FieldOffset(20)]
		public float RateScale;
		
	}
	
}
#endif
#endif
