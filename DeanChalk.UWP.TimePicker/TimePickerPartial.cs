using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Shapes;

namespace DeanChalk.UWP.TimePicker
{
    [TemplatePart(Name = _p_00_Back, Type = typeof(Path))]
    [TemplatePart(Name = _p_05_Back, Type = typeof(Path))]
    [TemplatePart(Name = _p_10_Back, Type = typeof(Path))]
    [TemplatePart(Name = _p_15_Back, Type = typeof(Path))]
    [TemplatePart(Name = _p_20_Back, Type = typeof(Path))]
    [TemplatePart(Name = _p_25_Back, Type = typeof(Path))]
    [TemplatePart(Name = _p_30_Back, Type = typeof(Path))]
    [TemplatePart(Name = _p_35_Back, Type = typeof(Path))]
    [TemplatePart(Name = _p_40_Back, Type = typeof(Path))]
    [TemplatePart(Name = _p_45_Back, Type = typeof(Path))]
    [TemplatePart(Name = _p_50_Back, Type = typeof(Path))]
    [TemplatePart(Name = _p_55_Back, Type = typeof(Path))]
    [TemplatePart(Name = _p_1i_Back, Type = typeof(Path))]
    [TemplatePart(Name = _p_2i_Back, Type = typeof(Path))]
    [TemplatePart(Name = _p_3i_Back, Type = typeof(Path))]
    [TemplatePart(Name = _p_4i_Back, Type = typeof(Path))]
    [TemplatePart(Name = _p_5i_Back, Type = typeof(Path))]
    [TemplatePart(Name = _p_6i_Back, Type = typeof(Path))]
    [TemplatePart(Name = _p_7i_Back, Type = typeof(Path))]
    [TemplatePart(Name = _p_8i_Back, Type = typeof(Path))]
    [TemplatePart(Name = _p_9i_Back, Type = typeof(Path))]
    [TemplatePart(Name = _p_10i_Back, Type = typeof(Path))]
    [TemplatePart(Name = _p_11i_Back, Type = typeof(Path))]
    [TemplatePart(Name = _p_12i_Back, Type = typeof(Path))]
    [TemplatePart(Name = _p_AMPM_Back, Type = typeof(Path))]
    [TemplatePart(Name = _p_00_Front, Type = typeof(Path))]
    [TemplatePart(Name = _p_05_Front, Type = typeof(Path))]
    [TemplatePart(Name = _p_10_Front, Type = typeof(Path))]
    [TemplatePart(Name = _p_15_Front, Type = typeof(Path))]
    [TemplatePart(Name = _p_20_Front, Type = typeof(Path))]
    [TemplatePart(Name = _p_25_Front, Type = typeof(Path))]
    [TemplatePart(Name = _p_30_Front, Type = typeof(Path))]
    [TemplatePart(Name = _p_35_Front, Type = typeof(Path))]
    [TemplatePart(Name = _p_40_Front, Type = typeof(Path))]
    [TemplatePart(Name = _p_45_Front, Type = typeof(Path))]
    [TemplatePart(Name = _p_50_Front, Type = typeof(Path))]
    [TemplatePart(Name = _p_55_Front, Type = typeof(Path))]
    [TemplatePart(Name = _p_1i_Front, Type = typeof(Path))]
    [TemplatePart(Name = _p_2i_Front, Type = typeof(Path))]
    [TemplatePart(Name = _p_3i_Front, Type = typeof(Path))]
    [TemplatePart(Name = _p_4i_Front, Type = typeof(Path))]
    [TemplatePart(Name = _p_5i_Front, Type = typeof(Path))]
    [TemplatePart(Name = _p_6i_Front, Type = typeof(Path))]
    [TemplatePart(Name = _p_7i_Front, Type = typeof(Path))]
    [TemplatePart(Name = _p_8i_Front, Type = typeof(Path))]
    [TemplatePart(Name = _p_9i_Front, Type = typeof(Path))]
    [TemplatePart(Name = _p_10i_Front, Type = typeof(Path))]
    [TemplatePart(Name = _p_11i_Front, Type = typeof(Path))]
    [TemplatePart(Name = _p_12i_Front, Type = typeof(Path))]
    [TemplatePart(Name = _p_AMPM_Front, Type = typeof(Path))]
    [TemplatePart(Name = _p_05_Text, Type = typeof(TextBlock))]
    [TemplatePart(Name = _p_10_Text, Type = typeof(TextBlock))]
    [TemplatePart(Name = _p_15_Text, Type = typeof(TextBlock))]
    [TemplatePart(Name = _p_20_Text, Type = typeof(TextBlock))]
    [TemplatePart(Name = _p_25_Text, Type = typeof(TextBlock))]
    [TemplatePart(Name = _p_30_Text, Type = typeof(TextBlock))]
    [TemplatePart(Name = _p_35_Text, Type = typeof(TextBlock))]
    [TemplatePart(Name = _p_40_Text, Type = typeof(TextBlock))]
    [TemplatePart(Name = _p_45_Text, Type = typeof(TextBlock))]
    [TemplatePart(Name = _p_50_Text, Type = typeof(TextBlock))]
    [TemplatePart(Name = _p_55_Text, Type = typeof(TextBlock))]
    [TemplatePart(Name = _p_00_Text, Type = typeof(TextBlock))]
    [TemplatePart(Name = _p_1i_Text, Type = typeof(TextBlock))]
    [TemplatePart(Name = _p_2i_Text, Type = typeof(TextBlock))]
    [TemplatePart(Name = _p_3i_Text, Type = typeof(TextBlock))]
    [TemplatePart(Name = _p_4i_Text, Type = typeof(TextBlock))]
    [TemplatePart(Name = _p_5i_Text, Type = typeof(TextBlock))]
    [TemplatePart(Name = _p_6i_Text, Type = typeof(TextBlock))]
    [TemplatePart(Name = _p_7i_Text, Type = typeof(TextBlock))]
    [TemplatePart(Name = _p_8i_Text, Type = typeof(TextBlock))]
    [TemplatePart(Name = _p_9i_Text, Type = typeof(TextBlock))]
    [TemplatePart(Name = _p_10i_Text, Type = typeof(TextBlock))]
    [TemplatePart(Name = _p_11i_Text, Type = typeof(TextBlock))]
    [TemplatePart(Name = _p_12i_Text, Type = typeof(TextBlock))]
    [TemplatePart(Name = _p_AMPM_Text, Type = typeof(TextBlock))]
    public sealed partial class TimePicker : Control
    {
        private const string _p_00_Back = "PART_00_Back";
        private const string _p_05_Back = "PART_05_Back";
        private const string _p_10_Back = "PART_10_Back";
        private const string _p_15_Back = "PART_15_Back";
        private const string _p_20_Back = "PART_20_Back";
        private const string _p_25_Back = "PART_25_Back";
        private const string _p_30_Back = "PART_30_Back";
        private const string _p_35_Back = "PART_35_Back";
        private const string _p_40_Back = "PART_40_Back";
        private const string _p_45_Back = "PART_45_Back";
        private const string _p_50_Back = "PART_50_Back";
        private const string _p_55_Back = "PART_55_Back";

        private const string _p_1i_Back = "PART_1i_Back";
        private const string _p_2i_Back = "PART_2i_Back";
        private const string _p_3i_Back = "PART_3i_Back";
        private const string _p_4i_Back = "PART_4i_Back";
        private const string _p_5i_Back = "PART_5i_Back";
        private const string _p_6i_Back = "PART_6i_Back";
        private const string _p_7i_Back = "PART_7i_Back";
        private const string _p_8i_Back = "PART_8i_Back";
        private const string _p_9i_Back = "PART_9i_Back";
        private const string _p_10i_Back = "PART_10i_Back";
        private const string _p_11i_Back = "PART_11i_Back";
        private const string _p_12i_Back = "PART_12i_Back";
        private const string _p_AMPM_Back = "PART_AMPM_Back";

        private const string _p_00_Front = "PART_00_Front";
        private const string _p_05_Front = "PART_05_Front";
        private const string _p_10_Front = "PART_10_Front";
        private const string _p_15_Front = "PART_15_Front";
        private const string _p_20_Front = "PART_20_Front";
        private const string _p_25_Front = "PART_25_Front";
        private const string _p_30_Front = "PART_30_Front";
        private const string _p_35_Front = "PART_35_Front";
        private const string _p_40_Front = "PART_40_Front";
        private const string _p_45_Front = "PART_45_Front";
        private const string _p_50_Front = "PART_50_Front";
        private const string _p_55_Front = "PART_55_Front";

        private const string _p_1i_Front = "PART_1i_Front";
        private const string _p_2i_Front = "PART_2i_Front";
        private const string _p_3i_Front = "PART_3i_Front";
        private const string _p_4i_Front = "PART_4i_Front";
        private const string _p_5i_Front = "PART_5i_Front";
        private const string _p_6i_Front = "PART_6i_Front";
        private const string _p_7i_Front = "PART_7i_Front";
        private const string _p_8i_Front = "PART_8i_Front";
        private const string _p_9i_Front = "PART_9i_Front";
        private const string _p_10i_Front = "PART_10i_Front";
        private const string _p_11i_Front = "PART_11i_Front";
        private const string _p_12i_Front = "PART_12i_Front";
        private const string _p_AMPM_Front = "PART_AMPM_Front";

        private const string _p_05_Text = "PART_05_Text";
        private const string _p_10_Text = "PART_10_Text";
        private const string _p_15_Text = "PART_15_Text";
        private const string _p_20_Text = "PART_20_Text";
        private const string _p_25_Text = "PART_25_Text";
        private const string _p_30_Text = "PART_30_Text";
        private const string _p_35_Text = "PART_35_Text";
        private const string _p_40_Text = "PART_40_Text";
        private const string _p_45_Text = "PART_45_Text";
        private const string _p_50_Text = "PART_50_Text";
        private const string _p_55_Text = "PART_55_Text";
        private const string _p_00_Text = "PART_00_Text";

        private const string _p_1i_Text = "PART_1i_Text";
        private const string _p_2i_Text = "PART_2i_Text";
        private const string _p_3i_Text = "PART_3i_Text";
        private const string _p_4i_Text = "PART_4i_Text";
        private const string _p_5i_Text = "PART_5i_Text";
        private const string _p_6i_Text = "PART_6i_Text";
        private const string _p_7i_Text = "PART_7i_Text";
        private const string _p_8i_Text = "PART_8i_Text";
        private const string _p_9i_Text = "PART_9i_Text";
        private const string _p_10i_Text = "PART_10i_Text";
        private const string _p_11i_Text = "PART_11i_Text";
        private const string _p_12i_Text = "PART_12i_Text";
        private const string _p_AMPM_Text = "PART_AMPM_Text";
        private bool _hasAppliedTemplate;


        private Path _p_00_Back_Path;

        private Path _p_00_Front_Path;
        private TextBlock _p_00_TextBlock;
        private Path _p_05_Back_Path;
        private Path _p_05_Front_Path;

        private TextBlock _p_05_TextBlock;
        private Path _p_10_Back_Path;
        private Path _p_10_Front_Path;
        private TextBlock _p_10_TextBlock;
        private Path _p_10i_Back_Path;
        private Path _p_10i_Front_Path;
        private TextBlock _p_10i_TextBlock;
        private Path _p_11i_Back_Path;
        private Path _p_11i_Front_Path;
        private TextBlock _p_11i_TextBlock;
        private Path _p_12i_Back_Path;
        private Path _p_12i_Front_Path;
        private TextBlock _p_12i_TextBlock;
        private Path _p_15_Back_Path;
        private Path _p_15_Front_Path;
        private TextBlock _p_15_TextBlock;

        private Path _p_1i_Back_Path;

        private Path _p_1i_Front_Path;

        private TextBlock _p_1i_TextBlock;
        private Path _p_20_Back_Path;
        private Path _p_20_Front_Path;
        private TextBlock _p_20_TextBlock;
        private Path _p_25_Back_Path;
        private Path _p_25_Front_Path;
        private TextBlock _p_25_TextBlock;
        private Path _p_2i_Back_Path;
        private Path _p_2i_Front_Path;
        private TextBlock _p_2i_TextBlock;
        private Path _p_30_Back_Path;
        private Path _p_30_Front_Path;
        private TextBlock _p_30_TextBlock;
        private Path _p_35_Back_Path;
        private Path _p_35_Front_Path;
        private TextBlock _p_35_TextBlock;
        private Path _p_3i_Back_Path;
        private Path _p_3i_Front_Path;
        private TextBlock _p_3i_TextBlock;
        private Path _p_40_Back_Path;
        private Path _p_40_Front_Path;
        private TextBlock _p_40_TextBlock;
        private Path _p_45_Back_Path;
        private Path _p_45_Front_Path;
        private TextBlock _p_45_TextBlock;
        private Path _p_4i_Back_Path;
        private Path _p_4i_Front_Path;
        private TextBlock _p_4i_TextBlock;
        private Path _p_50_Back_Path;
        private Path _p_50_Front_Path;
        private TextBlock _p_50_TextBlock;
        private Path _p_55_Back_Path;
        private Path _p_55_Front_Path;
        private TextBlock _p_55_TextBlock;
        private Path _p_5i_Back_Path;
        private Path _p_5i_Front_Path;
        private TextBlock _p_5i_TextBlock;
        private Path _p_6i_Back_Path;
        private Path _p_6i_Front_Path;
        private TextBlock _p_6i_TextBlock;
        private Path _p_7i_Back_Path;
        private Path _p_7i_Front_Path;
        private TextBlock _p_7i_TextBlock;
        private Path _p_8i_Back_Path;
        private Path _p_8i_Front_Path;
        private TextBlock _p_8i_TextBlock;
        private Path _p_9i_Back_Path;
        private Path _p_9i_Front_Path;
        private TextBlock _p_9i_TextBlock;
        private Path _p_AMPM_Back_Path;
        private Path _p_AMPM_Front_Path;
        private TextBlock _p_AMPM_TextBlock;

        protected override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            _p_00_Back_Path = GetTemplateChild(_p_00_Back) as Path;
            _p_05_Back_Path = GetTemplateChild(_p_05_Back) as Path;
            _p_10_Back_Path = GetTemplateChild(_p_10_Back) as Path;
            _p_15_Back_Path = GetTemplateChild(_p_15_Back) as Path;
            _p_20_Back_Path = GetTemplateChild(_p_20_Back) as Path;
            _p_25_Back_Path = GetTemplateChild(_p_25_Back) as Path;
            _p_30_Back_Path = GetTemplateChild(_p_30_Back) as Path;
            _p_35_Back_Path = GetTemplateChild(_p_35_Back) as Path;
            _p_40_Back_Path = GetTemplateChild(_p_40_Back) as Path;
            _p_45_Back_Path = GetTemplateChild(_p_45_Back) as Path;
            _p_50_Back_Path = GetTemplateChild(_p_50_Back) as Path;
            _p_55_Back_Path = GetTemplateChild(_p_55_Back) as Path;

            _p_1i_Back_Path = GetTemplateChild(_p_1i_Back) as Path;
            _p_2i_Back_Path = GetTemplateChild(_p_2i_Back) as Path;
            _p_3i_Back_Path = GetTemplateChild(_p_3i_Back) as Path;
            _p_4i_Back_Path = GetTemplateChild(_p_4i_Back) as Path;
            _p_5i_Back_Path = GetTemplateChild(_p_5i_Back) as Path;
            _p_6i_Back_Path = GetTemplateChild(_p_6i_Back) as Path;
            _p_7i_Back_Path = GetTemplateChild(_p_7i_Back) as Path;
            _p_8i_Back_Path = GetTemplateChild(_p_8i_Back) as Path;
            _p_9i_Back_Path = GetTemplateChild(_p_9i_Back) as Path;
            _p_10i_Back_Path = GetTemplateChild(_p_10i_Back) as Path;
            _p_11i_Back_Path = GetTemplateChild(_p_11i_Back) as Path;
            _p_12i_Back_Path = GetTemplateChild(_p_12i_Back) as Path;

            _p_AMPM_Back_Path = GetTemplateChild(_p_AMPM_Back) as Path;

            _p_00_Front_Path = GetTemplateChild(_p_00_Front) as Path;
            _p_05_Front_Path = GetTemplateChild(_p_05_Front) as Path;
            _p_10_Front_Path = GetTemplateChild(_p_10_Front) as Path;
            _p_15_Front_Path = GetTemplateChild(_p_15_Front) as Path;
            _p_20_Front_Path = GetTemplateChild(_p_20_Front) as Path;
            _p_25_Front_Path = GetTemplateChild(_p_25_Front) as Path;
            _p_30_Front_Path = GetTemplateChild(_p_30_Front) as Path;
            _p_35_Front_Path = GetTemplateChild(_p_35_Front) as Path;
            _p_40_Front_Path = GetTemplateChild(_p_40_Front) as Path;
            _p_45_Front_Path = GetTemplateChild(_p_45_Front) as Path;
            _p_50_Front_Path = GetTemplateChild(_p_50_Front) as Path;
            _p_55_Front_Path = GetTemplateChild(_p_55_Front) as Path;

            _p_1i_Front_Path = GetTemplateChild(_p_1i_Front) as Path;
            _p_2i_Front_Path = GetTemplateChild(_p_2i_Front) as Path;
            _p_3i_Front_Path = GetTemplateChild(_p_3i_Front) as Path;
            _p_4i_Front_Path = GetTemplateChild(_p_4i_Front) as Path;
            _p_5i_Front_Path = GetTemplateChild(_p_5i_Front) as Path;
            _p_6i_Front_Path = GetTemplateChild(_p_6i_Front) as Path;
            _p_7i_Front_Path = GetTemplateChild(_p_7i_Front) as Path;
            _p_8i_Front_Path = GetTemplateChild(_p_8i_Front) as Path;
            _p_9i_Front_Path = GetTemplateChild(_p_9i_Front) as Path;
            _p_10i_Front_Path = GetTemplateChild(_p_10i_Front) as Path;
            _p_11i_Front_Path = GetTemplateChild(_p_11i_Front) as Path;
            _p_12i_Front_Path = GetTemplateChild(_p_12i_Front) as Path;

            _p_AMPM_Front_Path = GetTemplateChild(_p_AMPM_Front) as Path;

            _p_00_TextBlock = GetTemplateChild(_p_00_Text) as TextBlock;
            _p_05_TextBlock = GetTemplateChild(_p_05_Text) as TextBlock;
            _p_10_TextBlock = GetTemplateChild(_p_10_Text) as TextBlock;
            _p_15_TextBlock = GetTemplateChild(_p_15_Text) as TextBlock;
            _p_20_TextBlock = GetTemplateChild(_p_20_Text) as TextBlock;
            _p_25_TextBlock = GetTemplateChild(_p_25_Text) as TextBlock;
            _p_30_TextBlock = GetTemplateChild(_p_30_Text) as TextBlock;
            _p_35_TextBlock = GetTemplateChild(_p_35_Text) as TextBlock;
            _p_40_TextBlock = GetTemplateChild(_p_40_Text) as TextBlock;
            _p_45_TextBlock = GetTemplateChild(_p_45_Text) as TextBlock;
            _p_50_TextBlock = GetTemplateChild(_p_50_Text) as TextBlock;
            _p_55_TextBlock = GetTemplateChild(_p_55_Text) as TextBlock;

            _p_1i_TextBlock = GetTemplateChild(_p_1i_Text) as TextBlock;
            _p_2i_TextBlock = GetTemplateChild(_p_2i_Text) as TextBlock;
            _p_3i_TextBlock = GetTemplateChild(_p_3i_Text) as TextBlock;
            _p_4i_TextBlock = GetTemplateChild(_p_4i_Text) as TextBlock;
            _p_5i_TextBlock = GetTemplateChild(_p_5i_Text) as TextBlock;
            _p_6i_TextBlock = GetTemplateChild(_p_6i_Text) as TextBlock;
            _p_7i_TextBlock = GetTemplateChild(_p_7i_Text) as TextBlock;
            _p_8i_TextBlock = GetTemplateChild(_p_8i_Text) as TextBlock;
            _p_9i_TextBlock = GetTemplateChild(_p_9i_Text) as TextBlock;
            _p_10i_TextBlock = GetTemplateChild(_p_10i_Text) as TextBlock;
            _p_11i_TextBlock = GetTemplateChild(_p_11i_Text) as TextBlock;
            _p_12i_TextBlock = GetTemplateChild(_p_12i_Text) as TextBlock;

            _p_AMPM_TextBlock = GetTemplateChild(_p_AMPM_Text) as TextBlock;


            _minuteNumberControls.Add(_p_00_Front_Path,
                new NumberControl
                {
                    BackgroundCircle = _p_00_Back_Path,
                    ForegroundCircle = _p_00_Front_Path,
                    TextBlock = _p_00_TextBlock,
                    Value = 0
                });
            _minuteNumberControls.Add(_p_05_Front_Path,
                new NumberControl
                {
                    BackgroundCircle = _p_05_Back_Path,
                    ForegroundCircle = _p_05_Front_Path,
                    TextBlock = _p_05_TextBlock,
                    Value = 5
                });
            _minuteNumberControls.Add(_p_10_Front_Path,
                new NumberControl
                {
                    BackgroundCircle = _p_10_Back_Path,
                    ForegroundCircle = _p_10_Front_Path,
                    TextBlock = _p_10_TextBlock,
                    Value = 10
                });
            _minuteNumberControls.Add(_p_15_Front_Path,
                new NumberControl
                {
                    BackgroundCircle = _p_15_Back_Path,
                    ForegroundCircle = _p_15_Front_Path,
                    TextBlock = _p_15_TextBlock,
                    Value = 15
                });
            _minuteNumberControls.Add(_p_20_Front_Path,
                new NumberControl
                {
                    BackgroundCircle = _p_20_Back_Path,
                    ForegroundCircle = _p_20_Front_Path,
                    TextBlock = _p_20_TextBlock,
                    Value = 20
                });
            _minuteNumberControls.Add(_p_25_Front_Path,
                new NumberControl
                {
                    BackgroundCircle = _p_25_Back_Path,
                    ForegroundCircle = _p_25_Front_Path,
                    TextBlock = _p_25_TextBlock,
                    Value = 25
                });
            _minuteNumberControls.Add(_p_30_Front_Path,
                new NumberControl
                {
                    BackgroundCircle = _p_30_Back_Path,
                    ForegroundCircle = _p_30_Front_Path,
                    TextBlock = _p_30_TextBlock,
                    Value = 30
                });
            _minuteNumberControls.Add(_p_35_Front_Path,
                new NumberControl
                {
                    BackgroundCircle = _p_35_Back_Path,
                    ForegroundCircle = _p_35_Front_Path,
                    TextBlock = _p_35_TextBlock,
                    Value = 35
                });
            _minuteNumberControls.Add(_p_40_Front_Path,
                new NumberControl
                {
                    BackgroundCircle = _p_40_Back_Path,
                    ForegroundCircle = _p_40_Front_Path,
                    TextBlock = _p_40_TextBlock,
                    Value = 40
                });
            _minuteNumberControls.Add(_p_45_Front_Path,
                new NumberControl
                {
                    BackgroundCircle = _p_45_Back_Path,
                    ForegroundCircle = _p_45_Front_Path,
                    TextBlock = _p_45_TextBlock,
                    Value = 45
                });
            _minuteNumberControls.Add(_p_50_Front_Path,
                new NumberControl
                {
                    BackgroundCircle = _p_50_Back_Path,
                    ForegroundCircle = _p_50_Front_Path,
                    TextBlock = _p_50_TextBlock,
                    Value = 50
                });
            _minuteNumberControls.Add(_p_55_Front_Path,
                new NumberControl
                {
                    BackgroundCircle = _p_55_Back_Path,
                    ForegroundCircle = _p_55_Front_Path,
                    TextBlock = _p_55_TextBlock,
                    Value = 55
                });

            _hourNumberControls.Add(_p_1i_Front_Path,
                new NumberControl
                {
                    BackgroundCircle = _p_1i_Back_Path,
                    ForegroundCircle = _p_1i_Front_Path,
                    TextBlock = _p_1i_TextBlock,
                    Value = 1
                });
            _hourNumberControls.Add(_p_2i_Front_Path,
                new NumberControl
                {
                    BackgroundCircle = _p_2i_Back_Path,
                    ForegroundCircle = _p_2i_Front_Path,
                    TextBlock = _p_2i_TextBlock,
                    Value = 2
                });
            _hourNumberControls.Add(_p_3i_Front_Path,
                new NumberControl
                {
                    BackgroundCircle = _p_3i_Back_Path,
                    ForegroundCircle = _p_3i_Front_Path,
                    TextBlock = _p_3i_TextBlock,
                    Value = 3
                });
            _hourNumberControls.Add(_p_4i_Front_Path,
                new NumberControl
                {
                    BackgroundCircle = _p_4i_Back_Path,
                    ForegroundCircle = _p_4i_Front_Path,
                    TextBlock = _p_4i_TextBlock,
                    Value = 4
                });
            _hourNumberControls.Add(_p_5i_Front_Path,
                new NumberControl
                {
                    BackgroundCircle = _p_5i_Back_Path,
                    ForegroundCircle = _p_5i_Front_Path,
                    TextBlock = _p_5i_TextBlock,
                    Value = 5
                });
            _hourNumberControls.Add(_p_6i_Front_Path,
                new NumberControl
                {
                    BackgroundCircle = _p_6i_Back_Path,
                    ForegroundCircle = _p_6i_Front_Path,
                    TextBlock = _p_6i_TextBlock,
                    Value = 6
                });
            _hourNumberControls.Add(_p_7i_Front_Path,
                new NumberControl
                {
                    BackgroundCircle = _p_7i_Back_Path,
                    ForegroundCircle = _p_7i_Front_Path,
                    TextBlock = _p_7i_TextBlock,
                    Value = 7
                });
            _hourNumberControls.Add(_p_8i_Front_Path,
                new NumberControl
                {
                    BackgroundCircle = _p_8i_Back_Path,
                    ForegroundCircle = _p_8i_Front_Path,
                    TextBlock = _p_8i_TextBlock,
                    Value = 8
                });
            _hourNumberControls.Add(_p_9i_Front_Path,
                new NumberControl
                {
                    BackgroundCircle = _p_9i_Back_Path,
                    ForegroundCircle = _p_9i_Front_Path,
                    TextBlock = _p_9i_TextBlock,
                    Value = 9
                });
            _hourNumberControls.Add(_p_10i_Front_Path,
                new NumberControl
                {
                    BackgroundCircle = _p_10i_Back_Path,
                    ForegroundCircle = _p_10i_Front_Path,
                    TextBlock = _p_10i_TextBlock,
                    Value = 10
                });
            _hourNumberControls.Add(_p_11i_Front_Path,
                new NumberControl
                {
                    BackgroundCircle = _p_11i_Back_Path,
                    ForegroundCircle = _p_11i_Front_Path,
                    TextBlock = _p_11i_TextBlock,
                    Value = 11
                });
            _hourNumberControls.Add(_p_12i_Front_Path,
                new NumberControl
                {
                    BackgroundCircle = _p_12i_Back_Path,
                    ForegroundCircle = _p_12i_Front_Path,
                    TextBlock = _p_12i_TextBlock,
                    Value = 12
                });

            foreach (var path in _minuteNumberControls.Keys) path.Tapped += OnMinuteTapped;

            foreach (var path in _hourNumberControls.Keys) path.Tapped += OnHourTapped;

            _p_AMPM_Front_Path.Tapped += OnAmPmTapped;
            _hasAppliedTemplate = true;
            ChangeControlsFromNewTime();
        }
    }
}