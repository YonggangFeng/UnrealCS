#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=4)]
	public partial struct FMovieSceneSequenceID
	{
		[FieldOffset(0)]
		public uint Value;
		
	}
	
}
#endif
#endif
