﻿namespace PlainTextTable
{
    public enum TextTableStyle
    {
        /// <summary>
        /// Без рамок
        /// </summary>
        NoBorders,
        /// <summary>
        /// Рамки из символов !+-
        /// </summary>
        Simple,
        /// <summary>
        /// Рамки из символов +|, только для первой и последней строки и колонок
        /// </summary>
        Columns,
        /// <summary>
        /// Полные рамки
        /// </summary>
        Borders,
        /// <summary>
        /// Линия для отделения названий колонок
        /// </summary>
        HeaderLine,
        /// <summary>
        /// Линии для отделения названий колонок и первого стоблца (названий строк)
        /// </summary>
        HeaderAndFirstColumn,
        /// <summary>
        /// Полные двойные рамки
        /// </summary>
        DoubleBorders,
        /// <summary>
        /// Двойная линия для отделения названий колонок
        /// </summary>
        DoubleHeaderLine,
        /// <summary>
        /// Двойные линии для отделения названий колонок и первого стоблца (названий строк)
        /// </summary>
        DoubleHeaderAndFirstColumn
    }
}
