﻿ <!--<Grid>
                    <Border Style="{StaticResource ShowControlBorder}">
                        <Metro:AduCalendar x:Name="Calendar1" HorizontalAlignment="Center" VerticalAlignment="Center"
                                     AduAttach:BackgroundElement.MouseOverBackground="{StaticResource DefaultBrush}"/>
                    </Border>
                </Grid>-->
                <!--<Grid>
                    <Border Style="{StaticResource ShowControlBorder}">
                        <StackPanel>
                            <Metro:AduDatePicker x:Name="Date1" HorizontalAlignment="Left" Margin="4" Width="200" VerticalAlignment="Center" Height="28" Type="DateTime"  CornerRadius="3" DateStringFormat="yyyy/MM/dd" />
                            <Metro:AduDatePicker x:Name="Date2" Margin="4" Width="200" VerticalAlignment="Center" HorizontalAlignment="Left" Height="28" CornerRadius="3"/>
                            <Metro:AduDatePicker x:Name="Date3" Margin="4" Width="200" VerticalAlignment="Center" HorizontalAlignment="Left" Height="28" CornerRadius="3" IsShowShortCuts="True" />
                            <Metro:AduDatePicker x:Name="Date4" Margin="4" Width="200" VerticalAlignment="Center" HorizontalAlignment="Left" Height="28" Type="SingleDateRange" CornerRadius="3" DateStringFormat="yyyy/MM/dd" IsShowShortCuts="True" />
                            <Metro:AduDatePicker x:Name="Date5" HorizontalAlignment="Left" Margin="4" Width="240" VerticalAlignment="Center" Height="28" Type="SingleDateRange" CornerRadius="3" />
                            <Metro:AduDatePicker x:Name="Date6" HorizontalAlignment="Left" Margin="4" Width="240" VerticalAlignment="Center" Height="28" Type="SingleDateRange" CornerRadius="3"/>
                        </StackPanel>
                    </Border>
                </Grid>-->
                <Grid>
                    <Border Style="{StaticResource ShowControlBorder}">
                        <StackPanel>
                            <Metro:AduLoading Margin="0,0,0,20" SpeedRatio=".5" Type="Cogs" IsActived="True"/>
                            <Metro:AduLoading Margin="0,0,0,20" SpeedRatio="1" Type="SingleRound" IsActived="True"/>
                            <Metro:AduLoading Margin="0,0,0,20" SpeedRatio="1" Type="DoubleRound" IsActived="True"/>
                            <Metro:AduLoading Margin="0,0,0,20" SpeedRatio="1" Type="Apple" IsActived="True"/>
                            <Metro:AduLoading Margin="0,0,0,20" SpeedRatio="1" Type="Lines" IsActived="True" Height="30"/>
                            <Metro:AduLoading Margin="0,0,0,0" SpeedRatio="1" Type="Rotate" IsActived="True" Width="40" Height="40"/>
                        </StackPanel>
                    </Border>
                </Grid>
                <Grid>
                    <Border Style="{StaticResource ShowControlBorder}">
                        <StackPanel>
                            <Metro:AduRadioButtonIcon
                                                            Content="盒子"
                                                            IsChecked="True"
                                                            
                                                            AduAttach:IconElement.Width="16"/>
                            <Metro:AduRadioButtonIcon
                                                            Content="菜单"
                                                            
                                                            AduAttach:IconElement.Width="16"/>
                            <Metro:AduRadioButtonIcon
                                                            Content="轮播"
                                                            
                                                            AduAttach:IconElement.Width="16"/>
                            <Metro:AduRadioButtonIcon
                                                            Content="组"
                                                            
                                                            AduAttach:IconElement.Width="16"/>
                            <Metro:AduRadioButtonIcon
                                                            Content="时间轴"
                                                            
                                                            AduAttach:IconElement.Width="16"/>
                            <Metro:AduRadioButtonIcon
                                                            Content="瀑布流"
                                                            
                                                            AduAttach:IconElement.Width="16"/>
                        </StackPanel>
                    </Border>
                </Grid>
                <Grid>
                    <Border Style="{StaticResource ShowControlBorder}">
                        <StackPanel>
                            <StackPanel Orientation="Horizontal">
                                <Metro:AduCheckBox Content="禁用未选择" FontSize="14" IconWidth="16" IsChecked="False" IsEnabled="False" />
                                <Metro:AduCheckBox Content="默认未选择" FontSize="14" IconWidth="16" IsChecked="False" />
                            </StackPanel>
                            <StackPanel Orientation="Horizontal">
                                <Metro:AduCheckBox Content="禁用已选择" FontSize="14" IconWidth="16" IsChecked="True" IsEnabled="False" />
                                <Metro:AduCheckBox Content="默认已选择" FontSize="14" IconWidth="16" IsChecked="True" />
                            </StackPanel>
                        </StackPanel>
                    </Border>
                </Grid>
                <Grid>
                    <Border Style="{StaticResource ShowControlBorder}">
                        <StackPanel Orientation="Horizontal">
                            <Metro:AduComboBox Width="100" Height="30" IsEditable="True" Foreground="#FFF" Watermark="请选择" Background="Transparent" Margin="10,10,0,10"  CornerRadius="3">
                                <ComboBoxItem Content="上海" Tag="1" />
                                <ComboBoxItem Content="北京" Tag="1" />
                                <ComboBoxItem Content="追求极致，永臻完美" Tag="1" />
                            </Metro:AduComboBox>
                            <Metro:AduComboBox Width="auto" Height="30" SelectedIndex="0" Margin="10,10,0,10"  CornerRadius="3">
                                <ComboBoxItem Content="1080*1920" Tag="1" />
                                <ComboBoxItem Content="768*1366" Tag="1" />
                                <ComboBoxItem Content="760*1024" Tag="1" />
                            </Metro:AduComboBox>
                        </StackPanel>
                    </Border>
                </Grid>
                <Grid>
                    <Border Style="{StaticResource ShowControlBorder}">
                        <StackPanel Orientation="Horizontal" HorizontalAlignment="Center">
                            <Metro:AduIntegerUpDown Width="100" Maximum="20"
                                          Minimum="0" Value="15" UpDownOrientation="Horizontal" />
                            <Metro:AduIntegerUpDown Width="100" Height="30" Margin="10,0" Maximum="20"
                                          Minimum="0" Value="15" UpDownOrientation="Vertical" />
                        </StackPanel>
                    </Border>
                </Grid>
                <Grid>
                    <Border Style="{StaticResource ShowControlBorder}">
                        <Metro:AduUpload Height="100" BorderBrush="{StaticResource DefaultBrush}" Foreground="{StaticResource DefaultBrush}"/>
                    </Border>
                </Grid>
                <Grid Height="250">
                    <Border Style="{StaticResource ShowControlBorder}">
                        <Metro:MetroScrollViewer>
                            <StackPanel>
                                <Metro:AduNoExpander Header="不可折叠" IsExpanded="True">
                                    <StackPanel HorizontalAlignment="Left">
                                        <Metro:AduRadioButton Content="单选框" FontSize="14" IconWidth="16" IsChecked="True" />
                                        <Metro:AduRadioButton Content="单选框" FontSize="14" IconWidth="16" />
                                    </StackPanel>
                                </Metro:AduNoExpander>
                                <Metro:AduExpander Header="可折叠" IsEnabled="True" IsExpanded="True"  AduAttach:IconElement.Width="14">
                                    <StackPanel>
                                        <Metro:AduCheckBox Content="复选框" FontSize="14" IconWidth="16" IsChecked="True" />
                                        <Metro:AduCheckBox Content="复选框" FontSize="14" IconWidth="16" IsChecked="True" />
                                        <Metro:AduCheckBox Content="复选框" FontSize="14" IconWidth="16" IsChecked="True" />
                                        <Metro:AduCheckBox Content="复选框" FontSize="14" IconWidth="16" IsChecked="True" />
                                    </StackPanel>
                                </Metro:AduExpander>
                            </StackPanel>
                        </Metro:MetroScrollViewer>
                    </Border>
                </Grid>
                <Grid>
                    <Border Style="{StaticResource ShowControlBorder}">
                        <StackPanel>
                            <Metro:AduSlider Maximum="1000" Value="500" Margin="0,10" Height="3"/>
                            <Metro:AduFlatSilder Maximum="1000" Value="500" Margin="0,10" Height="17"/>
                        </StackPanel>
                    </Border>
                </Grid>
                <Grid>
                    <Border Style="{StaticResource ShowControlBorder}">
                        <StackPanel>
                            <Metro:RatingBar VerticalAlignment="Center" Height="30" Value="3" IsShowContent="True" IsReadOnly="False"/>
                            <Metro:RatingBar VerticalAlignment="Center" Height="30" Value="3.7"/>
                            <Metro:RatingBar VerticalAlignment="Center" Height="30" Value="3" Maximum="10" IsShowContent="True" ContentStringFormat="{}{0}星" />
                        </StackPanel>
                    </Border>
                </Grid>
                <Grid>
                    <Border Style="{StaticResource ShowControlBorder}">
                        <StackPanel>
                            <Metro:MetroTextBlock Opacity="0.65" Text="自动调整大小，不用管图片的PPI" />
                            <Metro:MetroImage Margin="0,5,0,0" Source="../Resources/pic.jpg" RenderOptions.BitmapScalingMode="Fant"/>
                        </StackPanel>
                    </Border>
                </Grid>
                <Grid>
                    <Border Style="{StaticResource ShowControlBorder}">
                        <StackPanel>
                            <StackPanel Orientation="Horizontal" HorizontalAlignment="Left">
                                <Metro:AduRadioButton
                                                                Content="禁用已选择"
                                                                FontSize="14"
                                                                IconWidth="16"
                                                                IsEnabled="False" />
                                <Metro:AduRadioButton
                                                                Content="禁用已选择"
                                                                FontSize="14"
                                                                IconWidth="16"
                                                                IsChecked="True"
                                                                IsEnabled="False" />
                            </StackPanel>
                            <StackPanel Orientation="Horizontal">
                                <Metro:AduRadioButton
                                                                Content="禁用已选择"
                                                                FontSize="14"
                                                                IconWidth="16"
                                                                IsChecked="False" />
                                <Metro:AduRadioButton
                                                                Content="禁用已选择"
                                                                FontSize="14"
                                                                IconWidth="16"
                                                                IsChecked="True" />
                            </StackPanel>
                        </StackPanel>
                    </Border>
                </Grid>
                <Grid>
                    <Border Style="{StaticResource ShowControlBorder}">
                        <StackPanel>
                            <Metro:MetroSwitch
                                                        Margin="10"
                                                        Content="关闭禁用"
                                                        IsEnabled="False" />
                            <Metro:MetroSwitch
                                                        Margin="10"
                                                        Content="打开禁用"
                                                        IsChecked="true"
                                                        IsEnabled="False" />
                            <Metro:MetroSwitch
                                                        Margin="10"
                                                        Content="可以修改对齐方式"
                                                        IsChecked="true"
                                                        TextHorizontalAlignment="Right" />
                            <Metro:MetroSwitch
                                                        x:Name="ts"
                                                        Margin="10"
                                                        Content="特殊动画"
                                                        CornerRadius="100" />
                            <Metro:MetroSwitch
                                                        Margin="10"
                                                        BorderCornerRadius="3"
                                                        Content="方块模式"
                                                        CornerRadius="2" />
                        </StackPanel>
                    </Border>
                </Grid>
                <Grid>
                    <Border Style="{StaticResource ShowControlBorder}">
                        <StackPanel>
                            <!--<Metro:AduFormLable Title="日期选择" ErrorVisibility="Collapsed" ErrorMessage="12312">
                                <Metro:AduDatePicker CornerRadius="3"/>
                            </Metro:AduFormLable>-->
                            <Metro:AduFormLable Title="下拉选择" Margin="0,10,0,0" ErrorVisibility="Visible" ErrorMessage="3232">
                                <Metro:AduComboBox>
                                    <ComboBoxItem Content="上海" Tag="1" IsSelected="True"/>
                                    <ComboBoxItem Content="北京" Tag="1" />
                                    <ComboBoxItem Content="广州" Tag="1" />
                                </Metro:AduComboBox>
                            </Metro:AduFormLable>
                            <Metro:AduFormLable Title="密码" Margin="0,10,0,0">
                                <Metro:AduPasswordBox/>
                            </Metro:AduFormLable>
                            <Metro:AduFormLable Title="选择目录" Margin="0,10,0,0">
                                <Metro:AduChooseBox AduChooseBoxType="SingleFile"/>
                            </Metro:AduFormLable>
                            <Metro:AduPasswordBox Margin="0,10,0,10"  Height="30" IsCanSeePassword="True"  Watermark="请输入密码"></Metro:AduPasswordBox>
                            <!--<Metro:MetroTextBox
                                                        x:Name="password"
                                                        ButtonTitle="确定"
                                                        InputHint="PassWord Input Box!"
                                                        IsPassWordBox="True"
                                                        PopupHint="请输入密码" />
                            <Metro:MetroTextBox
                                                        Margin="0,10,0,0"
                                                        InputHint="InputHint..."
                                                        PopupHint="This is TextBox!" />
                            <Metro:MetroTextBox Margin="0,10,0,0" />
                            <Metro:MetroTextBox
                                                        Title="Default Title"
                                                        Margin="0,10,0,0"
                                                        InputHint="InputHint..."
                                                        PopupHint="This is TextBox!" />
                            <Metro:MetroTextBox
                                                        x:Name="check"
                                                        Title="Default Title"
                                                        Margin="0,10,0,0"
                                                        ButtonTitle="Button"
                                                        Icon="../Resources/editIcon.png"
                                                        InputHint="InputHint..."
                                                        PopupHint="Length is more than 10!" />
                            <Metro:MetroTextBox
                                                        x:Name="check1"
                                                        Title="Default Title"
                                                        Margin="0,10,0,0"
                                                        ButtonTitle="Button"
                                                        Icon="../Resources/editIcon.png"
                                                        InputHint="InputHint..."
                                                        PopupHint="Length is more than 10!"
                                                        Text="0123456789" />
                            <Metro:MetroTextBox
                                                        Title="Default Title"
                                                        Margin="0,10,0,0"
                                                        ButtonTitle="Button"
                                                        Icon="../Resources/editIcon.png"
                                                        InputHint="InputHint..."
                                                        MultipleLine="True"
                                                        PopupHint="这是一个多行编辑框!"
                                                        Text="This is Content!" />
                            <Metro:MetroTextBox
                                                        Title="Default Title"
                                                        Margin="0,10,0,0"
                                                        ButtonTitle="Button"
                                                        Icon="../Resources/editIcon.png"
                                                        InputHint="InputHint..."
                                                        IsEnabled="False"
                                                        PopupHint="Length is more than 10!" />
                            <Metro:MetroTextBox
                                                        Title="Default Title"
                                                        Margin="0,10,0,0"
                                                        ButtonTitle="Button"
                                                        Icon="../Resources/editIcon.png"
                                                        InputHint="InputHint..."
                                                        IsEnabled="False"
                                                        PopupHint="Length is more than 10!"
                                                        Text="已经输入内容且禁用" />-->
                        </StackPanel>
                    </Border>
                </Grid>
                <Grid>
                    <Border Style="{StaticResource ShowControlBorder}">
                        <StackPanel HorizontalAlignment="Center">
                            <StackPanel Orientation="Horizontal">
                                <Metro:AduFlatButton Margin="10" Content="默认颜色" IsEnabled="False" Type="success" />
                                <Metro:AduFlatButton Margin="10" Content="默认颜色" Type="success" />
                            </StackPanel>
                            <StackPanel Orientation="Horizontal">
                                <Metro:AduFlatButton Margin="10" Content="错误颜色"  IsEnabled="False" Type="warning" />
                                <Metro:AduFlatButton Margin="10" Content="错误颜色" Type="warning" />
                            </StackPanel>
                            <StackPanel Orientation="Horizontal">
                                <Metro:AduFlatButton Margin="10" Content="错误颜色"  IsEnabled="False" Type="info" />
                                <Metro:AduFlatButton Margin="10" Content="错误颜色" Type="info" />
                            </StackPanel>
                            <StackPanel Orientation="Horizontal">
                                <Metro:AduFlatButton  Margin="10" Content="正确颜色" IsEnabled="False" Type="error" />
                                <Metro:AduFlatButton Name="btnShowAdu" Margin="10" Content="正确颜色" Type="error" />
                            </StackPanel>
                            <StackPanel Orientation="Horizontal">
                                <Metro:AduSysButton Foreground="#555" Margin="10" CornerRadius="6" Height="40" Width="40" Icon="{StaticResource Icon_Browser}" Content="" />
                                <Metro:AduButtonTransparent Width="40"  Margin="10" CornerRadius="3" Foreground="#000" Icon="{StaticResource Icon_Map}" IconHeight="18" />
                                <Metro:AduButtonSvg Icon="{StaticResource Icon_Logo}"  IconHeight="22" IconWidth="20" Foreground="#999" Height="40" Width="40" />
                            </StackPanel>
                            <StackPanel Orientation="Horizontal">
                                <Metro:AduButtonIcon Height="40" AduAttach:IconElement.Width="16"
                                    Margin="10" Width="120" CornerRadius="6" Content="hehhe" Foreground="#000" />
                                <Metro:AduCheckButton Margin="10" Content="AduSkin" PathData="{StaticResource Icon_Logo}" CheckedPathColor="#F34336" NormalPathColor="#555555" MouseOverPathColor="#0293EC" PressedPathColor="#FF9900"/>
                                <Metro:AduDIYCheckBox />
                            </StackPanel>
                        </StackPanel>
                    </Border>
                </Grid>
                <Grid>
                    <Border Style="{StaticResource ShowControlBorder}">
                        <StackPanel>
                            <Metro:MetroRichTextBox MaxHeight="50" Margin="5" CornerRadius="1" IsEnabled="False">
                                <FlowDocument>
                                    <Paragraph>
                                        <Run Text="禁用" />
                                    </Paragraph>
                                </FlowDocument>
                            </Metro:MetroRichTextBox>
                            <Metro:MetroRichTextBox x:Name="rt1" MaxHeight="50" Margin="5" CornerRadius="1"  IsReadOnly="True">
                                <FlowDocument>
                                    <Paragraph>
                                        <Run Text="阅读模式" />
                                    </Paragraph>
                                </FlowDocument>
                            </Metro:MetroRichTextBox>
                            <Metro:MetroRichTextBox
                                                            x:Name="rt3"
                                                            MaxHeight="100"
                                                            Margin="5"
                                                            AutoLimitMouse="True"
                                                            CornerRadius="1">
                                <FlowDocument>
                                    <Paragraph>
                                        <Run Text="追加内容" />
                                    </Paragraph>
                                    <Paragraph>
                                        <Run Text="自动高度" />
                                    </Paragraph>
                                </FlowDocument>
                            </Metro:MetroRichTextBox>
                            <Metro:MetroRichTextBox
                                                            MaxHeight="100"
                                                            Margin="5"
                                                            Background="#00000000"
                                                            BorderThickness="0"
                                                            CornerRadius="0"
                                                            IsEnabled="False">
                                <FlowDocument>
                                    <Paragraph>
                                        <Run Text="修改外观的 MetroRichTextBox" />
                                    </Paragraph>
                                    <Paragraph>
                                        <Run Text="禁用" />
                                    </Paragraph>
                                </FlowDocument>
                            </Metro:MetroRichTextBox>
                            <Metro:MetroRichTextBox
                                                            MaxHeight="100"
                                                            Margin="5"
                                                            Background="#00000000"
                                                            BorderThickness="0"
                                                            CornerRadius="0">
                                <FlowDocument>
                                    <Paragraph>
                                        <Run Text="修改外观的 MetroRichTextBox" />
                                    </Paragraph>
                                    <Paragraph>
                                        <Run Text="正常" />
                                    </Paragraph>
                                </FlowDocument>
                            </Metro:MetroRichTextBox>
                        </StackPanel>
                    </Border>
                </Grid>
                <Grid>
                    <Border Style="{StaticResource ShowControlBorder}">
                        <StackPanel Background="#00000000">
                            <Metro:MetroProgressBar
                                                            Margin="5"
                                                            Background="#FF555C65"
                                                            CornerRadius="10"
                                                            IsEnabled="False"
                                                            ProgressBarHeight="20"
                                                            ProgressBarState="None"
                                                            Value="15" />
                            <Metro:MetroProgressBar
                                                            x:Name="pb1"
                                                            Title="MetroProgressBar 调整"
                                                            Margin="5"
                                                            Background="#FF555C65"
                                                            CornerRadius="10"
                                                            ProgressBarHeight="20"
                                                            ProgressBarState="None"
                                                            TextHorizontalAlignment="Center"
                                                            Value="20" />
                            <Metro:MetroProgressBar
                                                            x:Name="pb2"
                                                            Title="MetroProgressBar 正常"
                                                            Margin="5"
                                                            Background="#FF555C65"
                                                            Maximum="50"
                                                            TextHorizontalAlignment="Right"
                                                            Value="0" />
                            <Metro:MetroProgressBar
                                                            Title="MetroProgressBar 错误"
                                                            Margin="5"
                                                            ProgressBarState="Error"
                                                            Value="40" />
                        </StackPanel>
                    </Border>
                </Grid>
                <Grid>
                    <Border Style="{StaticResource ShowControlBorder}">
                        <StackPanel>
                            <Metro:MetroCanvasGrid
                                                            Height="100"
                                                            Margin="5"
                                                            CornerRadius="2" />
                            <Metro:MetroCanvasGrid
                                                            Height="100"
                                                            Margin="5"
                                                            CornerRadius="2"
                                                            GridOpacity="1"
                                                            IsApplyTheme="False"
                                                            Viewport="0 0 20 20" />
                        </StackPanel>
                    </Border>
                </Grid>
                <Grid>
                    <Border Style="{StaticResource ShowControlBorder}">
                        <StackPanel Background="#00000000">
                            <Metro:MetroProgressBar
                                                            Title="MetroProgressBar 等待禁用"
                                                            Margin="60,5,5,5"
                                                            Background="#FF555C65"
                                                            IsEnabled="False"
                                                            ProgressBarState="Wait" />
                            <Metro:MetroProgressBar
                                                            x:Name="vis"
                                                            Title="MetroProgressBar 等待"
                                                            Margin="5"
                                                            Background="#FF555C65"
                                                            ProgressBarState="Wait" />
                            <!--<Metro:MetroVisualElement
                                                            Width="{Binding ActualWidth, ElementName=vis}"
                                                            Height="{Binding ActualHeight, ElementName=vis}"
                                                            Visual="{Binding ElementName=vis}"
                                                            VisualBlurRadius="10"
                                                            VisualOpacity="0.5" />-->
                            <Metro:MetroProgressBar
                                                            Title="MetroProgressBar 等待调整大小"
                                                            Margin="5,5,60,5"
                                                            Background="#FF555C65"
                                                            CornerRadius="5"
                                                            ProgressBarHeight="10"
                                                            ProgressBarState="Wait" />
                        </StackPanel>
                    </Border>
                </Grid>