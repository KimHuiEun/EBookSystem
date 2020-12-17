﻿
namespace EBookDevexpress
{
    partial class Age_GenreChartForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // uiChart_Main
            // 
            this.uiChart_Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.uiChart_Main.DataSource = this.rentBindingSource;
            xyDiagram3D1.RotationMatrixSerializable = "0.766044443118978;-0.219846310392954;0.604022773555054;0;0;0.939692620785908;0.34" +
    "2020143325669;0;-0.642787609686539;-0.262002630229385;0.719846310392954;0;0;0;0;" +
    "1";
            this.uiChart_Main.Diagram = xyDiagram3D1;
            this.uiChart_Main.Legend.Name = "Default Legend";
            this.uiChart_Main.Location = new System.Drawing.Point(-1, 26);
            this.uiChart_Main.Name = "uiChart_Main";
            this.uiChart_Main.PaletteName = "Red Orange";
            this.uiChart_Main.SeriesDataMember = "Genre";
            this.uiChart_Main.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.uiChart_Main.SeriesTemplate.ArgumentDataMember = "Decade";
            this.uiChart_Main.SeriesTemplate.SeriesDataMember = "Genre";
            this.uiChart_Main.SeriesTemplate.ValueDataMembersSerializable = "Count";
            this.uiChart_Main.SeriesTemplate.View = line3DSeriesView1;
            this.uiChart_Main.Size = new System.Drawing.Size(918, 677);
            this.uiChart_Main.TabIndex = 0;
            // 
            // commandBarGalleryDropDown1
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown1.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown1.Gallery.ColumnCount = 4;
            createBarChartItem1.Caption = "Clustered Column";
            createBarChartItem1.Description = "Compare values across categories by using vertical rectangles.\r\n\r\nUse it when the" +
    " order of categories is not important or for displaying item counts such as a hi" +
    "stogram.";
            createBarChartItem1.Hint = "Compare values across categories by using vertical rectangles.\r\n\r\nUse it when the" +
    " order of categories is not important or for displaying item counts such as a hi" +
    "stogram.";
            createFullStackedBarChartItem1.Caption = "100% Stacked Column";
            createFullStackedBarChartItem1.Description = "Compare the percentage that each value contributes to a total across categories b" +
    "y using vertical rectangles.\r\n\r\nUse it to emphasize the proportion of each data " +
    "series.";
            createFullStackedBarChartItem1.Hint = "Compare the percentage that each value contributes to a total across categories b" +
    "y using vertical rectangles.\r\n\r\nUse it to emphasize the proportion of each data " +
    "series.";
            createSideBySideFullStackedBarChartItem1.Caption = "Clustered 100% Stacked Column";
            createSideBySideFullStackedBarChartItem1.Description = "Combine the advantages of both the 100% Stacked Column and Clustered Column chart" +
    " types, so that you can stack different columns, and combine them into groups ac" +
    "ross the same axis value.";
            createSideBySideFullStackedBarChartItem1.Hint = "Combine the advantages of both the 100% Stacked Column and Clustered Column chart" +
    " types, so that you can stack different columns, and combine them into groups ac" +
    "ross the same axis value.";
            createSideBySideStackedBarChartItem1.Caption = "Clustered Stacked Column";
            createSideBySideStackedBarChartItem1.Description = "Combine the advantages of both the Stacked Column and Clustered Column chart type" +
    "s, so that you can stack different columns, and combine them into groups across " +
    "the same axis value.";
            createSideBySideStackedBarChartItem1.Hint = "Combine the advantages of both the Stacked Column and Clustered Column chart type" +
    "s, so that you can stack different columns, and combine them into groups across " +
    "the same axis value.";
            createStackedBarChartItem1.Caption = "Stacked Column";
            createStackedBarChartItem1.Description = "Compare the contribution of each value to a total across categories by using vert" +
    "ical rectangles.\r\n\r\nUse it to emphasize the total across series for one category" +
    ".";
            createStackedBarChartItem1.Hint = "Compare the contribution of each value to a total across categories by using vert" +
    "ical rectangles.\r\n\r\nUse it to emphasize the total across series for one category" +
    ".";
            createWaterfallChartItem1.Caption = "Waterfall";
            createWaterfallChartItem1.Description = "A Waterfall chart displays a sequence of bars that indicate positive or negative " +
    "changes.";
            createWaterfallChartItem1.Hint = "A Waterfall chart displays a sequence of bars that indicate positive or negative " +
    "changes.";
            chartControlCommandGalleryItemGroup2DColumn1.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createBarChartItem1,
            createFullStackedBarChartItem1,
            createSideBySideFullStackedBarChartItem1,
            createSideBySideStackedBarChartItem1,
            createStackedBarChartItem1,
            createWaterfallChartItem1});
            createBar3DChartItem1.Caption = "3-D Clustered Column";
            createBar3DChartItem1.Description = "Compare values across categories and display clustered columns in 3-D format.";
            createBar3DChartItem1.Hint = "Compare values across categories and display clustered columns in 3-D format.";
            createFullStackedBar3DChartItem1.Caption = "100% Stacked Column in 3-D";
            createFullStackedBar3DChartItem1.Description = "Compare the percentage each value contributes to a total across categories and di" +
    "splay 100% stacked columns in 3-D format.";
            createFullStackedBar3DChartItem1.Hint = "Compare the percentage each value contributes to a total across categories and di" +
    "splay 100% stacked columns in 3-D format.";
            createManhattanBarChartItem1.Caption = "3-D Column";
            createManhattanBarChartItem1.Description = "Compare values across categories and across series on three axes.\r\n\r\nUse it when " +
    "the categories and series are equally important.";
            createManhattanBarChartItem1.Hint = "Compare values across categories and across series on three axes.\r\n\r\nUse it when " +
    "the categories and series are equally important.";
            createSideBySideFullStackedBar3DChartItem1.Caption = "Clustered 100% Stacked Column in 3-D";
            createSideBySideFullStackedBar3DChartItem1.Description = "Combine the advantages of both the 100% Stacked Column and Clustered Column chart" +
    " types in 3-D format, so that you can stack different columns, and combine them " +
    "into groups across the same axis value.";
            createSideBySideFullStackedBar3DChartItem1.Hint = "Combine the advantages of both the 100% Stacked Column and Clustered Column chart" +
    " types in 3-D format, so that you can stack different columns, and combine them " +
    "into groups across the same axis value.";
            createSideBySideStackedBar3DChartItem1.Caption = "Clustered Stacked Column in 3-D";
            createSideBySideStackedBar3DChartItem1.Description = "Combine the advantages of both the Stacked Column and Clustered Column chart type" +
    "s in 3-D format, so that you can stack different columns, and combine them into " +
    "groups across the same axis value.";
            createSideBySideStackedBar3DChartItem1.Hint = "Combine the advantages of both the Stacked Column and Clustered Column chart type" +
    "s in 3-D format, so that you can stack different columns, and combine them into " +
    "groups across the same axis value.";
            createStackedBar3DChartItem1.Caption = "Stacked Column in 3-D";
            createStackedBar3DChartItem1.Description = "Compare the contribution of each value to a total across categories and display s" +
    "tacked columns in 3-D format.";
            createStackedBar3DChartItem1.Hint = "Compare the contribution of each value to a total across categories and display s" +
    "tacked columns in 3-D format.";
            chartControlCommandGalleryItemGroup3DColumn1.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createBar3DChartItem1,
            createFullStackedBar3DChartItem1,
            createManhattanBarChartItem1,
            createSideBySideFullStackedBar3DChartItem1,
            createSideBySideStackedBar3DChartItem1,
            createStackedBar3DChartItem1});
            createCylinderBar3DChartItem1.Caption = "Clustered Cylinder";
            createCylinderBar3DChartItem1.Description = "Compare values across categories.";
            createCylinderBar3DChartItem1.Hint = "Compare values across categories.";
            createCylinderFullStackedBar3DChartItem1.Caption = "100% Stacked Cylinder";
            createCylinderFullStackedBar3DChartItem1.Description = "Compare the percentage each value contributes to a total across categories.";
            createCylinderFullStackedBar3DChartItem1.Hint = "Compare the percentage each value contributes to a total across categories.";
            createCylinderManhattanBarChartItem1.Caption = "3-D Cylinder";
            createCylinderManhattanBarChartItem1.Description = "Compare values across categories and across series and display a cylinder chart o" +
    "n three axes.";
            createCylinderManhattanBarChartItem1.Hint = "Compare values across categories and across series and display a cylinder chart o" +
    "n three axes.";
            createCylinderSideBySideFullStackedBar3DChartItem1.Caption = "Clustered 100% Stacked Cylinder";
            createCylinderSideBySideFullStackedBar3DChartItem1.Description = "Combine the advantages of both the 100% Stacked Cylinder and Clustered Cylinder c" +
    "hart types, so that you can stack different cylinders, and combine them into gro" +
    "ups across the same axis value.";
            createCylinderSideBySideFullStackedBar3DChartItem1.Hint = "Combine the advantages of both the 100% Stacked Cylinder and Clustered Cylinder c" +
    "hart types, so that you can stack different cylinders, and combine them into gro" +
    "ups across the same axis value.";
            createCylinderSideBySideStackedBar3DChartItem1.Caption = "Clustered Stacked Cylinder";
            createCylinderSideBySideStackedBar3DChartItem1.Description = "Combine the advantages of both the Stacked Cylinder and Clustered Cylinder chart " +
    "types, so that you can stack different cylinders, and combine them into groups a" +
    "cross the same axis value.";
            createCylinderSideBySideStackedBar3DChartItem1.Hint = "Combine the advantages of both the Stacked Cylinder and Clustered Cylinder chart " +
    "types, so that you can stack different cylinders, and combine them into groups a" +
    "cross the same axis value.";
            createCylinderStackedBar3DChartItem1.Caption = "Stacked Cylinder";
            createCylinderStackedBar3DChartItem1.Description = "Compare the contribution of each value to a total across categories.";
            createCylinderStackedBar3DChartItem1.Hint = "Compare the contribution of each value to a total across categories.";
            chartControlCommandGalleryItemGroupCylinderColumn1.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createCylinderBar3DChartItem1,
            createCylinderFullStackedBar3DChartItem1,
            createCylinderManhattanBarChartItem1,
            createCylinderSideBySideFullStackedBar3DChartItem1,
            createCylinderSideBySideStackedBar3DChartItem1,
            createCylinderStackedBar3DChartItem1});
            createConeBar3DChartItem1.Caption = "Clustered Cone";
            createConeBar3DChartItem1.Description = "Compare values across categories.";
            createConeBar3DChartItem1.Hint = "Compare values across categories.";
            createConeFullStackedBar3DChartItem1.Caption = "100% Stacked Cone";
            createConeFullStackedBar3DChartItem1.Description = "Compare the percentage each value contributes to a total across categories.";
            createConeFullStackedBar3DChartItem1.Hint = "Compare the percentage each value contributes to a total across categories.";
            createConeManhattanBarChartItem1.Caption = "3-D Cone";
            createConeManhattanBarChartItem1.Description = "Compare values across categories and across series and display a cone chart on th" +
    "ree axes.";
            createConeManhattanBarChartItem1.Hint = "Compare values across categories and across series and display a cone chart on th" +
    "ree axes.";
            createConeSideBySideFullStackedBar3DChartItem1.Caption = "Clustered 100% Stacked Cone";
            createConeSideBySideFullStackedBar3DChartItem1.Description = "Combine the advantages of both the 100% Stacked Cone and Clustered Cone chart typ" +
    "es, so that you can stack different cones, and combine them into groups across t" +
    "he same axis value.";
            createConeSideBySideFullStackedBar3DChartItem1.Hint = "Combine the advantages of both the 100% Stacked Cone and Clustered Cone chart typ" +
    "es, so that you can stack different cones, and combine them into groups across t" +
    "he same axis value.";
            createConeSideBySideStackedBar3DChartItem1.Caption = "Clustered Stacked Cone";
            createConeSideBySideStackedBar3DChartItem1.Description = "Combine the advantages of both the Stacked Cone and Clustered Cone chart types, s" +
    "o that you can stack different cones, and combine them into groups across the sa" +
    "me axis value.";
            createConeSideBySideStackedBar3DChartItem1.Hint = "Combine the advantages of both the Stacked Cone and Clustered Cone chart types, s" +
    "o that you can stack different cones, and combine them into groups across the sa" +
    "me axis value.";
            createConeStackedBar3DChartItem1.Caption = "Stacked Cone";
            createConeStackedBar3DChartItem1.Description = "Compare the contribution of each value to a total across categories.";
            createConeStackedBar3DChartItem1.Hint = "Compare the contribution of each value to a total across categories.";
            chartControlCommandGalleryItemGroupConeColumn1.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createConeBar3DChartItem1,
            createConeFullStackedBar3DChartItem1,
            createConeManhattanBarChartItem1,
            createConeSideBySideFullStackedBar3DChartItem1,
            createConeSideBySideStackedBar3DChartItem1,
            createConeStackedBar3DChartItem1});
            createPyramidBar3DChartItem1.Caption = "Clustered Pyramid";
            createPyramidBar3DChartItem1.Description = "Compare values across categories.";
            createPyramidBar3DChartItem1.Hint = "Compare values across categories.";
            createPyramidFullStackedBar3DChartItem1.Caption = "100% Stacked Pyramid";
            createPyramidFullStackedBar3DChartItem1.Description = "Compare the percentage each value contributes to a total across categories.";
            createPyramidFullStackedBar3DChartItem1.Hint = "Compare the percentage each value contributes to a total across categories.";
            createPyramidManhattanBarChartItem1.Caption = "3-D Pyramid";
            createPyramidManhattanBarChartItem1.Description = "Compare values across categories and across series and display a pyramid chart on" +
    " three axes.";
            createPyramidManhattanBarChartItem1.Hint = "Compare values across categories and across series and display a pyramid chart on" +
    " three axes.";
            createPyramidSideBySideFullStackedBar3DChartItem1.Caption = "Clustered 100% Stacked Pyramid";
            createPyramidSideBySideFullStackedBar3DChartItem1.Description = "Combine the advantages of both the 100% Stacked Pyramid and Clustered Pyramid cha" +
    "rt types, so that you can stack different pyramids, and combine them into groups" +
    " across the same axis value.";
            createPyramidSideBySideFullStackedBar3DChartItem1.Hint = "Combine the advantages of both the 100% Stacked Pyramid and Clustered Pyramid cha" +
    "rt types, so that you can stack different pyramids, and combine them into groups" +
    " across the same axis value.";
            createPyramidSideBySideStackedBar3DChartItem1.Caption = "Clustered Stacked Pyramid";
            createPyramidSideBySideStackedBar3DChartItem1.Description = "Combine the advantages of both the Stacked Pyramid and Clustered Pyramid chart ty" +
    "pes, so that you can stack different pyramids, and combine them into groups acro" +
    "ss the same axis value.";
            createPyramidSideBySideStackedBar3DChartItem1.Hint = "Combine the advantages of both the Stacked Pyramid and Clustered Pyramid chart ty" +
    "pes, so that you can stack different pyramids, and combine them into groups acro" +
    "ss the same axis value.";
            createPyramidStackedBar3DChartItem1.Caption = "Stacked Pyramid";
            createPyramidStackedBar3DChartItem1.Description = "Compare the contribution of each value to a total across categories.";
            createPyramidStackedBar3DChartItem1.Hint = "Compare the contribution of each value to a total across categories.";
            chartControlCommandGalleryItemGroupPyramidColumn1.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createPyramidBar3DChartItem1,
            createPyramidFullStackedBar3DChartItem1,
            createPyramidManhattanBarChartItem1,
            createPyramidSideBySideFullStackedBar3DChartItem1,
            createPyramidSideBySideStackedBar3DChartItem1,
            createPyramidStackedBar3DChartItem1});
            this.commandBarGalleryDropDown1.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            chartControlCommandGalleryItemGroup2DColumn1,
            chartControlCommandGalleryItemGroup3DColumn1,
            chartControlCommandGalleryItemGroupCylinderColumn1,
            chartControlCommandGalleryItemGroupConeColumn1,
            chartControlCommandGalleryItemGroupPyramidColumn1});
            this.commandBarGalleryDropDown1.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown1.Gallery.RowCount = 10;
            this.commandBarGalleryDropDown1.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown1.Manager = null;
            this.commandBarGalleryDropDown1.Name = "commandBarGalleryDropDown1";
            // 
            // commandBarGalleryDropDown2
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown2.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown2.Gallery.ColumnCount = 3;
            createLineChartItem1.Caption = "Line";
            createLineChartItem1.Description = "Displays trend overtime (dates, years) or ordered categories. Useful when there a" +
    "re many data points and the order is important.";
            createLineChartItem1.Hint = "Displays trend overtime (dates, years) or ordered categories. Useful when there a" +
    "re many data points and the order is important.";
            createFullStackedLineChartItem1.Caption = "100% Stacked Line";
            createFullStackedLineChartItem1.Description = "Displays the trend of the percentage each value contributes over time or ordered " +
    "categories.";
            createFullStackedLineChartItem1.Hint = "Displays the trend of the percentage each value contributes over time or ordered " +
    "categories.";
            createScatterLineChartItem1.Caption = "Scatter Line";
            createScatterLineChartItem1.Description = "Represent series points in the same order that they have in the collection.";
            createScatterLineChartItem1.Hint = "Represent series points in the same order that they have in the collection.";
            createSplineChartItem1.Caption = "Spline";
            createSplineChartItem1.Description = "Plot a fitted curve through each data point in a series.";
            createSplineChartItem1.Hint = "Plot a fitted curve through each data point in a series.";
            createStackedLineChartItem1.Caption = "Stacked Line";
            createStackedLineChartItem1.Description = "Displays the trend of the contribution of each value over time or ordered categor" +
    "ies.";
            createStackedLineChartItem1.Hint = "Displays the trend of the contribution of each value over time or ordered categor" +
    "ies.";
            createStepLineChartItem1.Caption = "Step Line";
            createStepLineChartItem1.Description = "Show to what extent values have changed for different points in the same series.";
            createStepLineChartItem1.Hint = "Show to what extent values have changed for different points in the same series.";
            chartControlCommandGalleryItemGroup2DLine1.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createLineChartItem1,
            createFullStackedLineChartItem1,
            createScatterLineChartItem1,
            createSplineChartItem1,
            createStackedLineChartItem1,
            createStepLineChartItem1});
            createLine3DChartItem1.Caption = "3-D Line";
            createLine3DChartItem1.Description = "Displays each row or column of data as a 3-D ribbon on three axes.";
            createLine3DChartItem1.Hint = "Displays each row or column of data as a 3-D ribbon on three axes.";
            createFullStackedLine3DChartItem1.Caption = "100% Stacked Line in 3-D";
            createFullStackedLine3DChartItem1.Description = "Displays all series stacked and is useful when it is necessary to compare how muc" +
    "h each series adds to the total aggregate value for specific arguments (as perce" +
    "nts).";
            createFullStackedLine3DChartItem1.Hint = "Displays all series stacked and is useful when it is necessary to compare how muc" +
    "h each series adds to the total aggregate value for specific arguments (as perce" +
    "nts).";
            createSpline3DChartItem1.Caption = "3-D Spline";
            createSpline3DChartItem1.Description = "Plot a fitted curve through each data point in a series.";
            createSpline3DChartItem1.Hint = "Plot a fitted curve through each data point in a series.";
            createStackedLine3DChartItem1.Caption = "Stacked Line in 3-D";
            createStackedLine3DChartItem1.Description = "Displays all points from different series in a stacked manner and is useful when " +
    "it is necessary to compare how much each series adds to the total aggregate valu" +
    "e for specific arguments.";
            createStackedLine3DChartItem1.Hint = "Displays all points from different series in a stacked manner and is useful when " +
    "it is necessary to compare how much each series adds to the total aggregate valu" +
    "e for specific arguments.";
            createStepLine3DChartItem1.Caption = "Step Line in 3-D";
            createStepLine3DChartItem1.Description = "Show to what extent values have changed for different points in the same series.";
            createStepLine3DChartItem1.Hint = "Show to what extent values have changed for different points in the same series.";
            chartControlCommandGalleryItemGroup3DLine1.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createLine3DChartItem1,
            createFullStackedLine3DChartItem1,
            createSpline3DChartItem1,
            createStackedLine3DChartItem1,
            createStepLine3DChartItem1});
            this.commandBarGalleryDropDown2.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            chartControlCommandGalleryItemGroup2DLine1,
            chartControlCommandGalleryItemGroup3DLine1});
            this.commandBarGalleryDropDown2.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown2.Gallery.RowCount = 4;
            this.commandBarGalleryDropDown2.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown2.Manager = null;
            this.commandBarGalleryDropDown2.Name = "commandBarGalleryDropDown2";
            // 
            // commandBarGalleryDropDown3
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown3.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown3.Gallery.ColumnCount = 3;
            createPieChartItem1.Caption = "Pie";
            createPieChartItem1.Description = "Displays the contribution of each value to a total.\r\n\r\nUse it when the values can" +
    " be added together or when you have only one data series and all values are posi" +
    "tive.";
            createPieChartItem1.Hint = "Displays the contribution of each value to a total.\r\n\r\nUse it when the values can" +
    " be added together or when you have only one data series and all values are posi" +
    "tive.";
            createDoughnutChartItem1.Caption = "Doughnut";
            createDoughnutChartItem1.Description = "Displays the contribution of each value to a total like a pie chart, but it can c" +
    "ontain multiple series.";
            createDoughnutChartItem1.Hint = "Displays the contribution of each value to a total like a pie chart, but it can c" +
    "ontain multiple series.";
            createNestedDoughnutChartItem1.Caption = "Nested Doughnut";
            createNestedDoughnutChartItem1.Description = "Displays the contribution of each value to a total while comparing series with on" +
    "e doughnut nested in another one.";
            createNestedDoughnutChartItem1.Hint = "Displays the contribution of each value to a total while comparing series with on" +
    "e doughnut nested in another one.";
            chartControlCommandGalleryItemGroup2DPie1.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createPieChartItem1,
            createDoughnutChartItem1,
            createNestedDoughnutChartItem1});
            createPie3DChartItem1.Caption = "Pie in 3-D";
            createPie3DChartItem1.Description = "Displays the contribution of each value to a total.";
            createPie3DChartItem1.Hint = "Displays the contribution of each value to a total.";
            createDoughnut3DChartItem1.Caption = "Doughnut in 3-D";
            createDoughnut3DChartItem1.Description = "Compare the percentage values of different point arguments in the same series, an" +
    "d illustrate these values as easy to understand pie slices, but with a hole in i" +
    "ts center.";
            createDoughnut3DChartItem1.Hint = "Compare the percentage values of different point arguments in the same series, an" +
    "d illustrate these values as easy to understand pie slices, but with a hole in i" +
    "ts center.";
            chartControlCommandGalleryItemGroup3DPie1.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createPie3DChartItem1,
            createDoughnut3DChartItem1});
            this.commandBarGalleryDropDown3.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            chartControlCommandGalleryItemGroup2DPie1,
            chartControlCommandGalleryItemGroup3DPie1});
            this.commandBarGalleryDropDown3.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown3.Gallery.RowCount = 2;
            this.commandBarGalleryDropDown3.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown3.Manager = null;
            this.commandBarGalleryDropDown3.Name = "commandBarGalleryDropDown3";
            // 
            // commandBarGalleryDropDown4
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown4.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown4.Gallery.ColumnCount = 3;
            createRotatedBarChartItem1.Caption = "Bar";
            createRotatedBarChartItem1.Description = "Insert a bar chart.\r\n\r\nBar charts are the best chart type for comparing multiple " +
    "values.";
            createRotatedBarChartItem1.Hint = "Insert a bar chart.\r\n\r\nBar charts are the best chart type for comparing multiple " +
    "values.";
            createRotatedFullStackedBarChartItem1.Caption = "100% Stacked Bar";
            createRotatedFullStackedBarChartItem1.Description = resources.GetString("createRotatedFullStackedBarChartItem1.Description");
            createRotatedFullStackedBarChartItem1.Hint = resources.GetString("createRotatedFullStackedBarChartItem1.Hint");
            createRotatedSideBySideFullStackedBarChartItem1.Caption = "Clustered 100% Stacked Bar";
            createRotatedSideBySideFullStackedBarChartItem1.Description = "Combine the advantages of both the 100% Stacked Bar and Clustered Bar chart types" +
    ", so you can stack different bars, and combine them into groups across the same " +
    "axis value.";
            createRotatedSideBySideFullStackedBarChartItem1.Hint = "Combine the advantages of both the 100% Stacked Bar and Clustered Bar chart types" +
    ", so you can stack different bars, and combine them into groups across the same " +
    "axis value.";
            createRotatedSideBySideStackedBarChartItem1.Caption = "Clustered Stacked Bar";
            createRotatedSideBySideStackedBarChartItem1.Description = "Combine the advantages of both the Stacked Bar and Clustered Bar chart types, so " +
    "that you can stack different bars, and combine them into groups across the same " +
    "axis value.";
            createRotatedSideBySideStackedBarChartItem1.Hint = "Combine the advantages of both the Stacked Bar and Clustered Bar chart types, so " +
    "that you can stack different bars, and combine them into groups across the same " +
    "axis value.";
            createRotatedStackedBarChartItem1.Caption = "Stacked Bar";
            createRotatedStackedBarChartItem1.Description = "Compare the contribution of each value to a total across categories by using hori" +
    "zontal rectangles.";
            createRotatedStackedBarChartItem1.Hint = "Compare the contribution of each value to a total across categories by using hori" +
    "zontal rectangles.";
            chartControlCommandGalleryItemGroup2DBar1.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createRotatedBarChartItem1,
            createRotatedFullStackedBarChartItem1,
            createRotatedSideBySideFullStackedBarChartItem1,
            createRotatedSideBySideStackedBarChartItem1,
            createRotatedStackedBarChartItem1});
            this.commandBarGalleryDropDown4.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            chartControlCommandGalleryItemGroup2DBar1});
            this.commandBarGalleryDropDown4.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown4.Gallery.RowCount = 2;
            this.commandBarGalleryDropDown4.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown4.Manager = null;
            this.commandBarGalleryDropDown4.Name = "commandBarGalleryDropDown4";
            // 
            // commandBarGalleryDropDown5
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown5.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown5.Gallery.ColumnCount = 4;
            createAreaChartItem1.Caption = "Area";
            createAreaChartItem1.Description = "Displays the trend of values over time or categories.";
            createAreaChartItem1.Hint = "Displays the trend of values over time or categories.";
            createFullStackedAreaChartItem1.Caption = "100% Stacked Area";
            createFullStackedAreaChartItem1.Description = "Displays the trend of the percentage each value contributes over time or categori" +
    "es.\r\n\r\nUse it to emphasize the trend in the proportion of each series.";
            createFullStackedAreaChartItem1.Hint = "Displays the trend of the percentage each value contributes over time or categori" +
    "es.\r\n\r\nUse it to emphasize the trend in the proportion of each series.";
            createFullStackedSplineAreaChartItem1.Caption = "100% Stacked Spline Area";
            createFullStackedSplineAreaChartItem1.Description = "Behave similar to 100% Stacked Area, but plot a fitted curve through each data po" +
    "int in a series.";
            createFullStackedSplineAreaChartItem1.Hint = "Behave similar to 100% Stacked Area, but plot a fitted curve through each data po" +
    "int in a series.";
            createFullStackedStepAreaChartItem1.Caption = "100% Stacked Step Area";
            createFullStackedStepAreaChartItem1.Description = "Behaves similarly to the 100% Stacked Area Chart but connects data points using h" +
    "orizontal and vertical lines.";
            createFullStackedStepAreaChartItem1.Hint = "Behaves similarly to the 100% Stacked Area Chart but connects data points using h" +
    "orizontal and vertical lines.";
            createSplineAreaChartItem1.Caption = "Spline Area";
            createSplineAreaChartItem1.Description = "Behave similar to Area Chart but plot a fitted curve through each data point in a" +
    " series.";
            createSplineAreaChartItem1.Hint = "Behave similar to Area Chart but plot a fitted curve through each data point in a" +
    " series.";
            createStackedAreaChartItem1.Caption = "Stacked Area";
            createStackedAreaChartItem1.Description = "Displays the trend of the contribution of each value over time or categories.\r\n\r\n" +
    "Use it to emphasize the trend in the total across series for one category.";
            createStackedAreaChartItem1.Hint = "Displays the trend of the contribution of each value over time or categories.\r\n\r\n" +
    "Use it to emphasize the trend in the total across series for one category.";
            createStackedStepAreaChartItem1.Caption = "Stacked Step Area";
            createStackedStepAreaChartItem1.Description = "Behaves similarly to the Stacked Area Chart but connects data points using horizo" +
    "ntal and vertical lines.";
            createStackedStepAreaChartItem1.Hint = "Behaves similarly to the Stacked Area Chart but connects data points using horizo" +
    "ntal and vertical lines.";
            createStackedSplineAreaChartItem1.Caption = "Stacked Spline Area";
            createStackedSplineAreaChartItem1.Description = "Behave similar to Stacked Area Chart but plot a fitted curve through each data po" +
    "int in a series.";
            createStackedSplineAreaChartItem1.Hint = "Behave similar to Stacked Area Chart but plot a fitted curve through each data po" +
    "int in a series.";
            createStepAreaChartItem1.Caption = "Step Area";
            createStepAreaChartItem1.Description = "Show how much values have changed for different points of the same series.";
            createStepAreaChartItem1.Hint = "Show how much values have changed for different points of the same series.";
            chartControlCommandGalleryItemGroup2DArea1.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createAreaChartItem1,
            createFullStackedAreaChartItem1,
            createFullStackedSplineAreaChartItem1,
            createFullStackedStepAreaChartItem1,
            createSplineAreaChartItem1,
            createStackedAreaChartItem1,
            createStackedStepAreaChartItem1,
            createStackedSplineAreaChartItem1,
            createStepAreaChartItem1});
            createArea3DChartItem1.Caption = "3-D Area";
            createArea3DChartItem1.Description = resources.GetString("createArea3DChartItem1.Description");
            createArea3DChartItem1.Hint = resources.GetString("createArea3DChartItem1.Hint");
            createFullStackedArea3DChartItem1.Caption = "100% Stacked Area in 3-D";
            createFullStackedArea3DChartItem1.Description = resources.GetString("createFullStackedArea3DChartItem1.Description");
            createFullStackedArea3DChartItem1.Hint = resources.GetString("createFullStackedArea3DChartItem1.Hint");
            createFullStackedSplineArea3DChartItem1.Caption = "100% Stacked Spline Area in 3-D";
            createFullStackedSplineArea3DChartItem1.Description = "Behave similar to 100% Stacked Area Chart in 3D, but plot a fitted curve through " +
    "each data point in a series.";
            createFullStackedSplineArea3DChartItem1.Hint = "Behave similar to 100% Stacked Area Chart in 3D, but plot a fitted curve through " +
    "each data point in a series.";
            createSplineArea3DChartItem1.Caption = "Spline Area in 3-D";
            createSplineArea3DChartItem1.Description = "Behave similar to 3D Area Chart, but plot a fitted curve through each data point " +
    "in a series.";
            createSplineArea3DChartItem1.Hint = "Behave similar to 3D Area Chart, but plot a fitted curve through each data point " +
    "in a series.";
            createStackedArea3DChartItem1.Caption = "Stacked Area in 3-D";
            createStackedArea3DChartItem1.Description = "Displays series as areas on a diagram, so that the value of each data point is ag" +
    "gregated with the underlying data points\' values.";
            createStackedArea3DChartItem1.Hint = "Displays series as areas on a diagram, so that the value of each data point is ag" +
    "gregated with the underlying data points\' values.";
            createStackedSplineArea3DChartItem1.Caption = "Stacked Spline Area in 3-D";
            createStackedSplineArea3DChartItem1.Description = "Behave similar to Stacked Area in 3D chart, but plot a fitted curve through each " +
    "data point in a series.";
            createStackedSplineArea3DChartItem1.Hint = "Behave similar to Stacked Area in 3D chart, but plot a fitted curve through each " +
    "data point in a series.";
            createStepArea3DChartItem1.Caption = "Step Area in 3-D";
            createStepArea3DChartItem1.Description = "Show to what extent values have changed for different points in the same series.";
            createStepArea3DChartItem1.Hint = "Show to what extent values have changed for different points in the same series.";
            chartControlCommandGalleryItemGroup3DArea1.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createArea3DChartItem1,
            createFullStackedArea3DChartItem1,
            createFullStackedSplineArea3DChartItem1,
            createSplineArea3DChartItem1,
            createStackedArea3DChartItem1,
            createStackedSplineArea3DChartItem1,
            createStepArea3DChartItem1});
            this.commandBarGalleryDropDown5.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            chartControlCommandGalleryItemGroup2DArea1,
            chartControlCommandGalleryItemGroup3DArea1});
            this.commandBarGalleryDropDown5.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown5.Gallery.RowCount = 5;
            this.commandBarGalleryDropDown5.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown5.Manager = null;
            this.commandBarGalleryDropDown5.Name = "commandBarGalleryDropDown5";
            // 
            // commandBarGalleryDropDown6
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown6.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown6.Gallery.ColumnCount = 4;
            createPointChartItem1.Caption = "Point";
            createPointChartItem1.Description = "Use it when it\'s necessary to show stand-alone data points on the same chart plot" +
    ".";
            createPointChartItem1.Hint = "Use it when it\'s necessary to show stand-alone data points on the same chart plot" +
    ".";
            createBubbleChartItem1.Caption = "Bubble";
            createBubbleChartItem1.Description = "Resemble a Scatter chart, but compare sets of three values instead of two. The th" +
    "ird value determines the size of the bubble marker.";
            createBubbleChartItem1.Hint = "Resemble a Scatter chart, but compare sets of three values instead of two. The th" +
    "ird value determines the size of the bubble marker.";
            chartControlCommandGalleryItemGroupPoint1.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createPointChartItem1,
            createBubbleChartItem1});
            createFunnelChartItem1.Caption = "Funnel";
            createFunnelChartItem1.Description = resources.GetString("createFunnelChartItem1.Description");
            createFunnelChartItem1.Hint = resources.GetString("createFunnelChartItem1.Hint");
            createFunnel3DChartItem1.Caption = "3-D Funnel";
            createFunnel3DChartItem1.Description = resources.GetString("createFunnel3DChartItem1.Description");
            createFunnel3DChartItem1.Hint = resources.GetString("createFunnel3DChartItem1.Hint");
            chartControlCommandGalleryItemGroupFunnel1.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createFunnelChartItem1,
            createFunnel3DChartItem1});
            createStockChartItem1.Caption = "Stock";
            createStockChartItem1.Description = resources.GetString("createStockChartItem1.Description");
            createStockChartItem1.Hint = resources.GetString("createStockChartItem1.Hint");
            createCandleStickChartItem1.Caption = "Candle Stick";
            createCandleStickChartItem1.Description = resources.GetString("createCandleStickChartItem1.Description");
            createCandleStickChartItem1.Hint = resources.GetString("createCandleStickChartItem1.Hint");
            chartControlCommandGalleryItemGroupFinancial1.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createStockChartItem1,
            createCandleStickChartItem1});
            createRadarPointChartItem1.Caption = "Radar Point";
            createRadarPointChartItem1.Description = "Show points from two or more different series on the same points arguments on a c" +
    "ircular grid that has multiple axes along which data can be plotted.";
            createRadarPointChartItem1.Hint = "Show points from two or more different series on the same points arguments on a c" +
    "ircular grid that has multiple axes along which data can be plotted.";
            createRadarLineChartItem1.Caption = "Radar Line";
            createRadarLineChartItem1.Description = "Show trends for several series and compare their values for the same points argum" +
    "ents on a circular grid that has multiple axes along which data can be plotted.";
            createRadarLineChartItem1.Hint = "Show trends for several series and compare their values for the same points argum" +
    "ents on a circular grid that has multiple axes along which data can be plotted.";
            createRadarAreaChartItem1.Caption = "Radar Area";
            createRadarAreaChartItem1.Description = "Displays series as filled area on a circular grid that has multiple axes along wh" +
    "ich data can be plotted.";
            createRadarAreaChartItem1.Hint = "Displays series as filled area on a circular grid that has multiple axes along wh" +
    "ich data can be plotted.";
            createRadarRangeAreaChartItem1.Caption = "Radar Range Area";
            createRadarRangeAreaChartItem1.Description = resources.GetString("createRadarRangeAreaChartItem1.Description");
            createRadarRangeAreaChartItem1.Hint = resources.GetString("createRadarRangeAreaChartItem1.Hint");
            createScatterRadarLineChartItem1.Caption = "Scatter Radar Line";
            createScatterRadarLineChartItem1.Description = resources.GetString("createScatterRadarLineChartItem1.Description");
            createScatterRadarLineChartItem1.Hint = resources.GetString("createScatterRadarLineChartItem1.Hint");
            chartControlCommandGalleryItemGroupRadar1.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createRadarPointChartItem1,
            createRadarLineChartItem1,
            createRadarAreaChartItem1,
            createRadarRangeAreaChartItem1,
            createScatterRadarLineChartItem1});
            createPolarPointChartItem1.Caption = "Polar Point";
            createPolarPointChartItem1.Description = "Show points from two or more different series on the same circular diagram on the" +
    " basis of angles.";
            createPolarPointChartItem1.Hint = "Show points from two or more different series on the same circular diagram on the" +
    " basis of angles.";
            createPolarLineChartItem1.Caption = "Polar Line";
            createPolarLineChartItem1.Description = "Show trends for several series and compare their values for the same points argum" +
    "ents on a circular diagram on the basis of angles.";
            createPolarLineChartItem1.Hint = "Show trends for several series and compare their values for the same points argum" +
    "ents on a circular diagram on the basis of angles.";
            createPolarAreaChartItem1.Caption = "Polar Area";
            createPolarAreaChartItem1.Description = "Displays series as filled area on a circular diagram on the basis of angles.";
            createPolarAreaChartItem1.Hint = "Displays series as filled area on a circular diagram on the basis of angles.";
            createPolarRangeAreaChartItem1.Caption = "Polar Range Area";
            createPolarRangeAreaChartItem1.Description = resources.GetString("createPolarRangeAreaChartItem1.Description");
            createPolarRangeAreaChartItem1.Hint = resources.GetString("createPolarRangeAreaChartItem1.Hint");
            createScatterPolarLineChartItem1.Caption = "Scatter Polar Line";
            createScatterPolarLineChartItem1.Description = resources.GetString("createScatterPolarLineChartItem1.Description");
            createScatterPolarLineChartItem1.Hint = resources.GetString("createScatterPolarLineChartItem1.Hint");
            chartControlCommandGalleryItemGroupPolar1.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createPolarPointChartItem1,
            createPolarLineChartItem1,
            createPolarAreaChartItem1,
            createPolarRangeAreaChartItem1,
            createScatterPolarLineChartItem1});
            createRangeBarChartItem1.Caption = "Range Column";
            createRangeBarChartItem1.Description = "Displays vertical columns along the Y-axis (the axis of values). Each column repr" +
    "esents a range of data for each argument value.";
            createRangeBarChartItem1.Hint = "Displays vertical columns along the Y-axis (the axis of values). Each column repr" +
    "esents a range of data for each argument value.";
            createSideBySideRangeBarChartItem1.Caption = "Clustered Range Column";
            createSideBySideRangeBarChartItem1.Description = "Show activity columns from different series grouped by their arguments. Each colu" +
    "mn represents a range of data with two values for each argument value.";
            createSideBySideRangeBarChartItem1.Hint = "Show activity columns from different series grouped by their arguments. Each colu" +
    "mn represents a range of data with two values for each argument value.";
            createRangeAreaChartItem1.Caption = "Range Area";
            createRangeAreaChartItem1.Description = resources.GetString("createRangeAreaChartItem1.Description");
            createRangeAreaChartItem1.Hint = resources.GetString("createRangeAreaChartItem1.Hint");
            createRangeArea3DChartItem1.Caption = "Range Area in 3-D";
            createRangeArea3DChartItem1.Description = resources.GetString("createRangeArea3DChartItem1.Description");
            createRangeArea3DChartItem1.Hint = resources.GetString("createRangeArea3DChartItem1.Hint");
            chartControlCommandGalleryItemGroupRange1.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createRangeBarChartItem1,
            createSideBySideRangeBarChartItem1,
            createRangeAreaChartItem1,
            createRangeArea3DChartItem1});
            createGanttChartItem1.Caption = "Gantt";
            createGanttChartItem1.Description = "Track different activities during the time frame.";
            createGanttChartItem1.Hint = "Track different activities during the time frame.";
            createSideBySideGanttChartItem1.Caption = "Clustered Gantt";
            createSideBySideGanttChartItem1.Description = resources.GetString("createSideBySideGanttChartItem1.Description");
            createSideBySideGanttChartItem1.Hint = resources.GetString("createSideBySideGanttChartItem1.Hint");
            chartControlCommandGalleryItemGroupGantt1.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createGanttChartItem1,
            createSideBySideGanttChartItem1});
            createBoxPlotChartItem1.Caption = "BoxPlot";
            createBoxPlotChartItem1.Description = resources.GetString("createBoxPlotChartItem1.Description");
            createBoxPlotChartItem1.Hint = resources.GetString("createBoxPlotChartItem1.Hint");
            chartControlCommandGalleryItemGroupBoxPlot1.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createBoxPlotChartItem1});
            this.commandBarGalleryDropDown6.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            chartControlCommandGalleryItemGroupPoint1,
            chartControlCommandGalleryItemGroupFunnel1,
            chartControlCommandGalleryItemGroupFinancial1,
            chartControlCommandGalleryItemGroupRadar1,
            chartControlCommandGalleryItemGroupPolar1,
            chartControlCommandGalleryItemGroupRange1,
            chartControlCommandGalleryItemGroupGantt1,
            chartControlCommandGalleryItemGroupBoxPlot1});
            this.commandBarGalleryDropDown6.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown6.Gallery.RowCount = 9;
            this.commandBarGalleryDropDown6.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown6.Manager = null;
            this.commandBarGalleryDropDown6.Name = "commandBarGalleryDropDown6";
            // 
            // commandBarGalleryDropDown7
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown7.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown7.Gallery.Appearance.ItemCaptionAppearance.Hovered.Options.UseFont = true;
            this.commandBarGalleryDropDown7.Gallery.Appearance.ItemCaptionAppearance.Hovered.Options.UseTextOptions = true;
            this.commandBarGalleryDropDown7.Gallery.Appearance.ItemCaptionAppearance.Hovered.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.commandBarGalleryDropDown7.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseFont = true;
            this.commandBarGalleryDropDown7.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseTextOptions = true;
            this.commandBarGalleryDropDown7.Gallery.Appearance.ItemCaptionAppearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.commandBarGalleryDropDown7.Gallery.Appearance.ItemCaptionAppearance.Pressed.Options.UseFont = true;
            this.commandBarGalleryDropDown7.Gallery.Appearance.ItemCaptionAppearance.Pressed.Options.UseTextOptions = true;
            this.commandBarGalleryDropDown7.Gallery.Appearance.ItemCaptionAppearance.Pressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.commandBarGalleryDropDown7.Gallery.Appearance.ItemDescriptionAppearance.Hovered.Options.UseFont = true;
            this.commandBarGalleryDropDown7.Gallery.Appearance.ItemDescriptionAppearance.Hovered.Options.UseTextOptions = true;
            this.commandBarGalleryDropDown7.Gallery.Appearance.ItemDescriptionAppearance.Hovered.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.commandBarGalleryDropDown7.Gallery.Appearance.ItemDescriptionAppearance.Normal.Options.UseFont = true;
            this.commandBarGalleryDropDown7.Gallery.Appearance.ItemDescriptionAppearance.Normal.Options.UseTextOptions = true;
            this.commandBarGalleryDropDown7.Gallery.Appearance.ItemDescriptionAppearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.commandBarGalleryDropDown7.Gallery.Appearance.ItemDescriptionAppearance.Pressed.Options.UseFont = true;
            this.commandBarGalleryDropDown7.Gallery.Appearance.ItemDescriptionAppearance.Pressed.Options.UseTextOptions = true;
            this.commandBarGalleryDropDown7.Gallery.Appearance.ItemDescriptionAppearance.Pressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.commandBarGalleryDropDown7.Gallery.ColumnCount = 1;
            this.commandBarGalleryDropDown7.Gallery.ImageSize = new System.Drawing.Size(160, 10);
            this.commandBarGalleryDropDown7.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft;
            this.commandBarGalleryDropDown7.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Right;
            skinPaddingEdges1.Bottom = -3;
            skinPaddingEdges1.Top = -3;
            this.commandBarGalleryDropDown7.Gallery.ItemImagePadding = skinPaddingEdges1;
            skinPaddingEdges2.Bottom = -3;
            skinPaddingEdges2.Top = -3;
            this.commandBarGalleryDropDown7.Gallery.ItemTextPadding = skinPaddingEdges2;
            this.commandBarGalleryDropDown7.Gallery.RowCount = 10;
            this.commandBarGalleryDropDown7.Gallery.ShowGroupCaption = false;
            this.commandBarGalleryDropDown7.Gallery.ShowItemText = true;
            this.commandBarGalleryDropDown7.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown7.Manager = null;
            this.commandBarGalleryDropDown7.Name = "commandBarGalleryDropDown7";
            // 
            // commandBarGalleryDropDown8
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown8.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown8.Gallery.ColumnCount = 7;
            this.commandBarGalleryDropDown8.Gallery.ImageSize = new System.Drawing.Size(80, 50);
            this.commandBarGalleryDropDown8.Gallery.RowCount = 4;
            this.commandBarGalleryDropDown8.Gallery.ShowGroupCaption = false;
            this.commandBarGalleryDropDown8.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown8.Manager = null;
            this.commandBarGalleryDropDown8.Name = "commandBarGalleryDropDown8";
            // 
            // chartBarController1
            // 
            this.chartBarController1.Control = this.uiChart_Main;
            // 
            // rentBindingSource
            // 
            this.rentBindingSource.DataSource = typeof(EBook.Data.RentSummary);
            // 
            // Age_GenreChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "Age_GenreChartForm";
            this.Text = "연령/장르 차트";
            this.ResumeLayout(false);

        }

        #endregion
    }
}