namespace AspNetCore.ReportingServices.ReportRendering
{
	internal sealed class DataValue
	{
		private string m_name;

		private object m_value;

		public string Name
		{
			get
			{
				return this.m_name;
			}
		}

		public object Value
		{
			get
			{
				return this.m_value;
			}
		}

		internal DataValue(string name, object value)
		{
			this.m_name = name;
			this.m_value = value;
		}
	}
}
