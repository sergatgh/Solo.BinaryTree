﻿using Solo.BinaryTree.Constructor.Infrastructure;

namespace Solo.BinaryTree.Constructor.Serializer
{
    public class InlineTreeFormatter : ITreeFormatter
    {
        public static readonly string DefaultTreeFormat =
            "{0} " + SpecialIndicators.RootToNodesDelimiter + " {1} " + SpecialIndicators.NodeToNodeDelimiter + " {2}"; 
        public static readonly InlineTreeFormatter Instance = new InlineTreeFormatter(DefaultTreeFormat);
        
        public InlineTreeFormatter(string messageFormat)
        {
            MessageFormat = messageFormat;
        }

        public string MessageFormat { get; }

        public string Format(Tree node)
        {
            if (node == null) return string.Empty;

            if (node.Left == null && node.Right == null) return string.Empty;

            return string.Format(MessageFormat, node.Data, node.Left?.Data ?? SpecialIndicators.NullNodeIndicator,
                node.Right?.Data ?? SpecialIndicators.NullNodeIndicator);

        }
    }
}