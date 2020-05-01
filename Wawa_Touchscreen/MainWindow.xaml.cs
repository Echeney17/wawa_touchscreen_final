<Window x:Class="Wawa_Touchscreen.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:local="clr-namespace:Wawa_Touchscreen"
        mc:Ignorable="d"
        Title="MainWindow" Height="450" Width="800">
    <Grid>
        <Image Source="Image1.png" Stretch="Fill" Opacity="0.3" OpacityMask="Black"/>
        <TextBox HorizontalAlignment="Left" Height="54" Margin="657,365,0,0" TextWrapping="Wrap" Text="Evan Cheney&#xA;Jason Reilly&#xA;Chi Lai" VerticalAlignment="Top" Width="135"/>
        <ListBox x:Name="Items" HorizontalAlignment="Left" Height="121" Margin="646,30,0,0" VerticalAlignment="Top" Width="125" SelectionChanged="ListBox_SelectionChanged">
            <ListBoxItem Content=""/>
            <ListBoxItem Content=""/>
            <ListBoxItem Content=""/>
            <ListBoxItem x:Name="___No_Name_" Content="" Selected="ListBoxItem_Selected"/>
        </ListBox>
        <Label x:Name="Items_Label" Content="Items Selected&#xD;&#xA;" HorizontalAlignment="Left" Margin="656,4,0,0" VerticalAlignment="Top" FontWeight="Bold" FontFamily="Arial Black" Foreground="#FFB61E1E"/>
        <Label Content="" HorizontalAlignment="Left" VerticalAlignment="Top"/>
        <Label Content="Touch the screen to order" HorizontalAlignment="Left" Margin="256,296,0,0" VerticalAlignment="Top" Width="325" Height="54" FontSize="20" FontWeight="Bold" AutomationProperties.IsColumnHeader="True"/>
        <Button x:Name="Touch" Content="" HorizontalAlignment="Left" Margin="66,53,0,0" VerticalAlignment="Top" Width="553" Height="346" RenderTransformOrigin="0.5,0.5" Click="Touch_Click" Opacity="0">
            <Button.OpacityMask>
                <SolidColorBrush Color="Black" Opacity="0"/>
            </Button.OpacityMask>
            <Button.Background>
                <SolidColorBrush Color="Black" Opacity="0"/>
            </Button.Background>
            <Button.BorderBrush>
                <SolidColorBrush Color="#FF707070" Opacity="0.01"/>
            </Button.BorderBrush>
            <Button.Foreground>
                <SolidColorBrush Color="Black" Opacity="0"/>
            </Button.Foreground>
            <Button.RenderTransform>
                <TransformGroup>
                    <ScaleTransform/>
                    <SkewTransform/>
                    <RotateTransform Angle="0.207"/>
                    <TranslateTransform/>
                </TransformGroup>
            </Button.RenderTransform>
        </Button>
    </Grid>
</Window>
