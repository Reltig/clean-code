﻿namespace Markdown;

public class CloseEmNode : SimpleTag
{
    public CloseEmNode(string text) : base(NodeType.CloseEmTag, text) { }
}