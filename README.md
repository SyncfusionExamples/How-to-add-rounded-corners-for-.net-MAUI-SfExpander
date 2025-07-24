# How to add rounded corners for .NET MAUI SfExpander?
This article demonstrates how to add rounded corners for [.NET MAUI SfExpander](https://www.syncfusion.com/maui-controls/maui-expander). In this example, the Border with StrokeShape as RoundRectangle is used to achieve the rounded corner for SfExpander.

**XAML:**

Add the Border control to the [SfExpander.Header](https://help.syncfusion.com/cr/maui/Syncfusion.maui.Expander.SfExpander.html#Syncfusion_Maui_Expander_SfExpander_Header) or [SfExpander.Content](https://help.syncfusion.com/cr/maui/Syncfusion.maui.Expander.SfExpander.html#Syncfusion_Maui_Expander_SfExpander_Content) and set the StrokeShape with a RoundRectangle to apply the corner radius. You can customize the corner radius based on the expanded state by binding the [IsExpanded](https://help.syncfusion.com/cr/maui/Syncfusion.maui.Expander.SfExpander.html#Syncfusion_Maui_Expander_SfExpander_IsExpanded) property and the converter.

 ```xml
    <ContentPage.Content>
        <ScrollView>
            <StackLayout Spacing="10">
                <syncfusion:SfExpander x:Name="expander1" HeaderIconPosition="None" IsExpanded="false">
                    <syncfusion:SfExpander.Header>
                        <Border BackgroundColor="#bbbfca">
                            <Border.StrokeShape>
                                <RoundRectangle CornerRadius="{Binding IsExpanded, Source={x:Reference expander1}, Converter={StaticResource CornerRadiusConverter}}"/>
                            </Border.StrokeShape>
                            <Grid HeightRequest="50">
                                <Label Text="Veg Pizza" TextColor="#495F6E" VerticalOptions="Center" Margin="20,0,0,0" 
                                       FontSize="16"/>
                                <Image Source="{Binding IsExpanded, Source={x:Reference expander1}, Converter={StaticResource ExpanderIconConverter}}" 
                                       Margin="0,0,20,0" HorizontalOptions="End" VerticalOptions="Center"
                                       HeightRequest="20" WidthRequest="20"/>
                            </Grid>
                        </Border>
                    </syncfusion:SfExpander.Header>
                    <syncfusion:SfExpander.Content>
                        <Border BackgroundColor="#dddddd">
                            <Border.StrokeShape>
                                <RoundRectangle CornerRadius="0,0,20,20"/>
                            </Border.StrokeShape>
                            <Grid Padding="20,15,20,15">
                                <Label Text="Veg pizza is prepared with the items that meet vegetarian standards by not including any meat or animal tissue products." 
                                       TextColor="#303030" VerticalOptions="Center" 
                                       FontSize="14" LineBreakMode="WordWrap"/>
                            </Grid>
                        </Border>
                    </syncfusion:SfExpander.Content>
                </syncfusion:SfExpander>
                
                <syncfusion:SfExpander x:Name="expander2" HeaderIconPosition="None" IsExpanded="true">
                    <syncfusion:SfExpander.Header>
                        <Border BackgroundColor="#bbbfca">
                            <Border.StrokeShape>
                                <RoundRectangle CornerRadius="{Binding IsExpanded, Source={x:Reference expander2}, Converter={StaticResource CornerRadiusConverter}}"/>
                            </Border.StrokeShape>
                            <Grid HeightRequest="50">
                                <Label Text="Non-veg Pizza" TextColor="#495F6E" VerticalOptions="Center" Margin="20,0,0,0"
                                       FontSize="16"/>
                                <Image Source="{Binding IsExpanded, Source={x:Reference expander2}, Converter={StaticResource ExpanderIconConverter}}" 
                                       Margin="0,0,20,0" HorizontalOptions="End" VerticalOptions="Center"
                                       HeightRequest="20" WidthRequest="20"/>
                            </Grid>
                        </Border>
                    </syncfusion:SfExpander.Header>
                    <syncfusion:SfExpander.Content>
                        <Border BackgroundColor="#dddddd">
                            <Border.StrokeShape>
                                <RoundRectangle CornerRadius="0,0,20,20"/>
                            </Border.StrokeShape>
                            <Grid Padding="20,15,20,15">
                                <Label Text="Non-veg pizza is prepared by including the meat and animal tissue products." 
                                       TextColor="#303030" VerticalOptions="Center"
                                       FontSize="14" LineBreakMode="WordWrap"/>
                            </Grid>
                        </Border>
                    </syncfusion:SfExpander.Content>
                </syncfusion:SfExpander>
            </StackLayout>
        </ScrollView>
    </ContentPage.Content>
 ```

 **C#**

 ```c#
    public class CornerRadiusConverter : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            return value != null && (bool)value ? new CornerRadius(20, 20, 0, 0) : new CornerRadius(20, 20, 20, 20);
        }
    }
 ```

Download the complete sample from [GitHub](https://github.com/SyncfusionExamples/How-to-add-rounded-corners-for-.net-MAUI-SfExpander)