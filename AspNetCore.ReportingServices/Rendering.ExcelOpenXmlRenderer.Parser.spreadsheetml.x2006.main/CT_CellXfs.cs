using System.Collections.Generic;
using System.IO;

namespace AspNetCore.ReportingServices.Rendering.ExcelOpenXmlRenderer.Parser.spreadsheetml.x2006.main
{
	internal class CT_CellXfs : OoxmlComplexType
	{
		private uint _count_attr;

		private bool _count_attr_is_specified;

		private List<CT_Xf> _xf;

		public uint Count_Attr
		{
			get
			{
				return this._count_attr;
			}
			set
			{
				this._count_attr = value;
				this._count_attr_is_specified = true;
			}
		}

		public bool Count_Attr_Is_Specified
		{
			get
			{
				return this._count_attr_is_specified;
			}
			set
			{
				this._count_attr_is_specified = value;
			}
		}

		public List<CT_Xf> Xf
		{
			get
			{
				return this._xf;
			}
			set
			{
				this._xf = value;
			}
		}

		public static string XfElementName
		{
			get
			{
				return "xf";
			}
		}

		protected override void InitAttributes()
		{
			this._count_attr_is_specified = false;
		}

		protected override void InitElements()
		{
		}

		protected override void InitCollections()
		{
			this._xf = new List<CT_Xf>();
		}

		public override void WriteAsRoot(TextWriter s, string tagName, int depth, Dictionary<string, string> namespaces)
		{
			this.WriteOpenTag(s, tagName, depth, namespaces, true);
			this.WriteElements(s, depth, namespaces);
			this.WriteCloseTag(s, tagName, depth, namespaces);
		}

		public override void Write(TextWriter s, string tagName, int depth, Dictionary<string, string> namespaces)
		{
			this.WriteOpenTag(s, tagName, depth, namespaces, false);
			this.WriteElements(s, depth, namespaces);
			this.WriteCloseTag(s, tagName, depth, namespaces);
		}

		public override void WriteOpenTag(TextWriter s, string tagName, int depth, Dictionary<string, string> namespaces, bool root)
		{
			s.Write("<");
			OoxmlComplexType.WriteXmlPrefix(s, namespaces, "http://schemas.openxmlformats.org/spreadsheetml/2006/main");
			s.Write(tagName);
			this.WriteAttributes(s);
			if (root)
			{
				foreach (string key in namespaces.Keys)
				{
					s.Write(" xmlns");
					if (namespaces[key] != "")
					{
						s.Write(":");
						s.Write(namespaces[key]);
					}
					s.Write("=\"");
					s.Write(key);
					s.Write("\"");
				}
			}
			s.Write(">");
		}

		public override void WriteCloseTag(TextWriter s, string tagName, int depth, Dictionary<string, string> namespaces)
		{
			s.Write("</");
			OoxmlComplexType.WriteXmlPrefix(s, namespaces, "http://schemas.openxmlformats.org/spreadsheetml/2006/main");
			s.Write(tagName);
			s.Write(">");
		}

		public override void WriteAttributes(TextWriter s)
		{
			if (this._count_attr_is_specified)
			{
				s.Write(" count=\"");
				OoxmlComplexType.WriteData(s, this._count_attr);
				s.Write("\"");
			}
		}

		public override void WriteElements(TextWriter s, int depth, Dictionary<string, string> namespaces)
		{
			this.Write_xf(s, depth, namespaces);
		}

		public void Write_xf(TextWriter s, int depth, Dictionary<string, string> namespaces)
		{
			if (this._xf != null)
			{
				foreach (CT_Xf item in this._xf)
				{
					if (item != null)
					{
						item.Write(s, "xf", depth + 1, namespaces);
					}
				}
			}
		}
	}
}
