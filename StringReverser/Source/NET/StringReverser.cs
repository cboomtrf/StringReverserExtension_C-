using System;
using System.Collections;
using System.Data;
using OutSystems.HubEdition.RuntimePlatform;
using OutSystems.RuntimePublic.Db;

namespace OutSystems.NssStringReverser {

	public class CssStringReverser: IssStringReverser {

		/// <summary>
		/// Reverses a string input
		/// </summary>
		/// <param name="ssTextIn"></param>
		/// <param name="ssTextOut"></param>
		public void MssReverse(string ssTextIn, out string ssTextOut) {
            // TODO: Write implementation for action
            char[] charArray = ssTextIn.ToCharArray();
            Array.Reverse(charArray);
            ssTextOut = new string(charArray);
        } // MssReverse

	} // CssStringReverser

} // OutSystems.NssStringReverser

