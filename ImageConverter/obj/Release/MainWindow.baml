   M S B A M L   `   `   `  ���� I  EImageConverter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:ImageConverterImageConverter  E'clr-namespace:ImageConverter.UiControlsImageConverter.UiControls      ImageConverter.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     .localclr-namespace:ImageConverter     >
UiControls'clr-namespace:ImageConverter.UiControls     -     � AllowsTransparency  .  � WindowStyle$
 None=� � 
ResizeMode$ NoResize=� J� 	AllowDrop .  � Title$ 
MainWindow��$	��450��$	��800�����	#00000000.���� 
������� �� CornerRadius$ 12�����#197DFF$��1q�._�� .+��� $	��Top=�$��24(�$��Impact)����	#FF54626F$��0,20,0,0q�$��Center=�$��Image Converter���� -    ��Name$ UpDownPanel��$��25��$��25��$
 14.5��$
��Left=�$	��Top=�$��	10,10,0,0q�����  �� 
TargetType" ��.���  �� Property � ��	 �� Value	 �#197DFF��  � ��$	 35����  �@��CornerRadius$	 3��
 �� Triggers
 P�  P� Property �@J�IsMouseOver P� Value . . ���  � ��	 �	#FF2474DC._��� $	����$��Center=�$��0q� � UseLayoutRounding . $��18(�$��Center=�$��-2,-9,-1,-8q�
�������$7��1/ImageConverter;component/Font/#Segoe MDL2 Assets)� J� RenderTransformOrigin$ 0.5,0.5&��� -   $ SelectFiles��$y�Visible=����#F4F8FF$��111,183,111,120q�._�� .+��� $��Center=�$��0,40,0,0q�$��Center=�$��Or drop files here.��� $��0,30,0,0q�$��Center=�$	��Top=�$	��200��$��40�� � ColumnDefinitions �� $
��156* ��� $��3* ��� $	��41* �.+��� -   $
��Auto��$	��0,2q����� " ��.���  � ��	 �#197DFF��  � ��$	 35����  �@��CornerRadius$	 3��
 P�  �@J�IsMouseOver . . ���  � ��	 �	#FF2474DC._�� .+��� $��16(�
�������$��Choose Files��$��	17,3,41,2q��� $��20(�
�������$	����$��Center=�$��Center=�$7��1/ImageConverter;component/Font/#Segoe MDL2 Assets)�$��0,2,4,2q�$��Right=�$��34��$��0q��� $��2��$
��Auto��$	��0,2q����� " ��.���  � ��	 �#197DFF��  � ��$	 35����  �@��CornerRadius$	 3��
 P�  �@J�IsMouseOver . . ���  � ��	 �	#FF2474DC._��� $��33(�
�������$	����$��Center=�$��Right=�$7��1/ImageConverter;component/Font/#Segoe MDL2 Assets)�$��0,1,5,3q�$��Right=�$��34��$��0q��� $	��Top=�$��0,9,8,0q� �� Orientation$ 
Horizontal=�$��Right=�.+��� $��0,0,10,0q����	#19161B22$ 3��._��� -   $��Microsoft YaHei UI)�$��Center=�$	��4,0q�$��Center=�$��16(�
���   �.��GitHub�� $��0,0,10,0q�$��Sitka Small)�$��Bottom=�$��0q�$��Center=�.��v1.3�� -   $��24��$��24��$��Right=�$��0,0,4,0q����� " ��.���  � ��	 �#197DFF��  � ��$	 35����  �@��CornerRadius$	 5��
 P�  �@J�IsMouseOver . . ���  � ��	 �	#FF2474DC._��� $��18(�
�������$	����$��Center=�$��Center=�$7��1/ImageConverter;component/Font/#Segoe MDL2 Assets)�$��0q�$ 0.5,0.5&��� -   $��24��$��24��$��Right=����� " ��.���  � ��	 �#197DFF��  � ��$	 35����  �@��CornerRadius$	 5��
 P�  �@J�IsMouseOver . . ���  � ��	 �	#FF2474DC._��� $��18(�
�������$	����$��Center=�$��Center=�$7��1/ImageConverter;component/Font/#Segoe MDL2 Assets)�$��0q�$ 0.5,0.5&�� -    �Name$ 
SelectedDD��$y�Hidden=�.+��� -	    ��Name$ 
StackPanel��$��10,82,10,37q��� $ 
Horizontal=�$��Bottom=�$
��Left=�$��	10,0,0,10q�.+��� -
   $��58��$��22������ " ��.���  � ��	 �#197DFF��  � ��$	 35����  �@��CornerRadius$	 3��
 P�  �@J�IsMouseOver . . ���  � ��	 �	#FF2474DC._��� $��Center=�$��Center=�$��Center=�$��Center=�$��0q� . 
�������$��Convert���� -   $ BorderCOnvertAddnew��$��46��$��22��$��3,0,0,0q����� " ��.���  � ��	 �#197DFF��  � ��$	 35����  �@��CornerRadius$	 3��
 P�  �@J�IsMouseOver . . ���  � ��	 �	#FF2474DC._��� $��Center=�$��Center=�$��Center=�$��Center=�$��0q� . 
�������$	��Add���� -   $ BorderCOnvertClear��$��49��$��22��$��3,0,0,0q����� " ��.���  � ��	 �#197DFF��  � ��$	 35����  �@��CornerRadius$	 3��
 P�  �@J�IsMouseOver . . ���  � ��	 �	#FF2474DC._��� $��Center=�$��Center=�$��Center=�$��Center=�$��0q� . 
�������$��	Clear all���� -   $ BorderCOnvertClearAT��$��65��$��22��$��3,0,0,0q����� " ��.���  � ��	 �#197DFF��  � ��$	 35����  �@��CornerRadius$	 3��
 P�  �@J�IsMouseOver . . ���  � ��	 �	#FF2474DC._��� $��Center=�$��Center=�$��Center=�$��Center=�$��0q� . 
�������$��Clear select���� $	��Top=�$��	10,52,0,0q�$ 
Horizontal=�.+�(   "ImageConverter.UiControls.ComboBox  -     Name$ TestUD��$
��Left=�$��25��$	��Top=�$	��137���� ���#197DFF$��25��$ 3��$	��Top=�$��10,0,0,0q�._��� -    ��Name$ LodingProggress��
�������.��-�� ���#197DFF$��25��$ 3��$	��Top=�$��10,0,0,0q�._��� -   $ RunTime��
�������.��-�� $��Bottom=�$��11(�$��Impact)����	#FF54626F$��0,0,8,0q�$��Right=�$��
By UnderKo��$��Center=� J� Opacity$	 0.7Q�