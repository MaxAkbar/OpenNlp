﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenNLP.Tools.Util.Trees
{
    /// <summary>
    /// A <code>TreeReader</code> adds functionality to another <code>Reader</code>
    /// by reading in Trees, or some descendant class.
    /// 
    /// @author Christopher Manning
    /// @author Roger Levy (mod. 2003/01)
    /// 
    /// Code...
    /// </summary>
    public interface ITreeReader
    {
        /// <summary>
        /// Reads a single tree
        /// </summary>
        /// <returns>A single tree, or <code>null</code> at end of file.</returns>
        Tree ReadTree();

        /// <summary>
        /// Close the Reader behind this <code>TreeReader</code>
        /// </summary>
        void Close();
    }
}