using System;
using System.Collections;
using System.Data;
using OutSystems.HubEdition.RuntimePlatform;

namespace OutSystems.NssStringReverser {

	public interface IssStringReverser {

		/// <summary>
		/// Reverses a string input
		/// </summary>
		/// <param name="ssTextIn"></param>
		/// <param name="ssTextOut"></param>
		void MssReverse(string ssTextIn, out string ssTextOut);

	} // IssStringReverser

} // OutSystems.NssStringReverser
