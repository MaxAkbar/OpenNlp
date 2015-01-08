﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenNLP.Tools.Util.Ling
{
    /// <summary>
    /// Something that implements the <code>HasWord</code> interface knows about words.
    /// 
    /// @author Christopher Manning
    /// 
    /// Code...
    /// </summary>
    public interface IHasWord
    {
        /// <summary>
        /// Return the word value of the label (or null if none).
        /// </summary>
        string GetWord();

        /// <summary>
        /// Set the word value for the label (if one is stored).
        /// </summary>
        void SetWord(string word);
    }
}