//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2018 June 08 14:02:11 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;

namespace go
{
    public static unsafe partial class main_package
    {
        [GeneratedCode("go2cs", "0.1.1.0")]
        public partial struct ColorList
        {
            public ColorList(NilType _)
            {
                // Field instance values
                //public DateTime When;
                //public string What = ""; <- string initialized to empty
                // Inherited interface initializations (set to null / default)
                // Inherited structure initializations
            }

            // Only include constructor if struct contains fields
            //public ColorList(params)
            //{
            //    this.Field = Field,
            //    // Inherited interface initializations
            //    // Inherited structure initializations
            //}

            // Enable comparisons between nil and ColorList struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(ColorList value, NilType nil) => value.Equals(default(ColorList));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(ColorList value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, ColorList value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, ColorList value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ColorList(NilType nil) => default(ColorList);
        }
    }
}