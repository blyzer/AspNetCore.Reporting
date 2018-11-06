using System;
using System.Runtime.Serialization;

namespace AspNetCore.ReportingServices.Diagnostics.Utilities
{
	[Serializable]
	internal sealed class ModelNotAutoGeneratedException : ReportCatalogException
	{
		public ModelNotAutoGeneratedException(string modelPath)
			: base(ErrorCode.rsModelNotGenerated, ErrorStrings.rsModelNotGenerated, null, null)
		{
		}

		private ModelNotAutoGeneratedException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}
	}
}
