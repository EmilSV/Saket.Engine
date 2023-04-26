using System;
using Saket.Engine.Typography.OpenFontFormat.Serialization;

namespace Saket.Engine.Filetypes.Font.OpenFontFormat.Tables
{
    /// <summary>
    /// prep – Control value program. 
    /// The Control Value Program consists of a set of TrueType instructions that will be executed whenever the font
    /// or point size or transformation matrix change and before each glyph is interpreted. Any instruction is legal in
    /// the CV Program but since no glyph is associated with it, instructions intended to move points within a
    /// particular glyph outline cannot be used in the CV Program. The name 'prep' is anachronistic (the table used to be known as the Pre Program table). 
    /// </summary>

    public class Table_prep : Table
	{
		public override uint Tag => 0x70726570;

		public int n;
		public byte[] instructions;

		public Table_prep(int n)
		{
			this.n = n;
		}

		public override void Deserialize(OFFReader reader)
		{
			reader.LoadBytes(n);
			instructions = new byte[n];
			for (int i = 0; i < n; i++)
			{
				reader.ReadUInt8(ref instructions[i]);
			}
		}

		public override void Serialize(OFFWriter reader)
		{
			throw new NotImplementedException();
		}
	}
}