   M S B A M L   `   `   `  ����b  ^WPF Project - Currency Converter 2 - DB, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulla5clr-namespace:WPF_Project___Currency_Converter_2___DB'WPF_Project___Currency_Converter_2___DB  5   	   8    2WPF_Project___Currency_Converter_2___DB.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Glocal5clr-namespace:WPF_Project___Currency_Converter_2___DB     5   	   Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/  5   	     � Title$  Currency Converter��5	   	    � SizeToContent$ WidthAndHeight=�6$   $	��550��6C   $	��800��6P   $	��550��6\   $	��800��6l   $	��550��6{   $	��800��6�   .��5
      �� -   5        $��tbMain��5
       �� TabStripPlacement$	 Top=�6   ��5   
   �� 5      6$   .@�5   
   �� -   5        $��tbConverter��5      $��Currency Converter��6%   .��5      �  � RowDefinitions 5      �� 5      $��50 �6$   �� 5      $	��100 �6$   �� 5      $	��150 �6$   �� 5      $��50 �6$   �� 5      $	��200 �6$   .+�5      �� $��2��6    �� CornerRadius$ 8��6&   $��5q�67   $��	50,5,50,5q�6K   ��5      �� 5      .��5      �  � Color$ MediumVioletRed��6+    � Offset$	 0.0Q�6C   � 5      $ 
DarkOrange��6+   $
 0.50Q�6>   5      ._�5      �� ��5      �� 5        �� 
StartPoint$	 0,0&�62    �� EndPoint$	 1,0&�6C   .��5!   "   � $ 	OrangeRed��6/   $	 0.0Q�6A   � 5"   "   $ Orange��6/   $
 0.50Q�6>   5#      5%      5&      �� 5'      $	��780��6   $��50��6)   	 �� Orientation$	 
Horizontal=�65   .+�5(      �� $��Currency Converter��6   $	��780��69   $��Center=�6E   $��Center=�5)      $��30(�66   
��� E��$
��Bold"�6[   $��	Agency FB)�6m   5*      �� 5+      $��1��6   .+�5,      �� $��Converted Currency��6   $��Center=�69   $��	Agency FB)�6V   $��20(�6m   $��SemiBold"�6{   �� 5-      -   5        $��lblCurrency��5-      $��40��6/   $	��780��6;   $��Center=�6G   $��Center=�5.      $��20(�66   $��	Agency FB)�6D   6^   5/      �� 50      $��2��6   $	 
Horizontal=�6*   $��90 0 0 0q�6C   .+�51      �� $��Enter Amount��6   $
��Left=�63   $��	20 30 0 0q�6U   $��	Agency FB)�6h   $��20(�6   $��SemiBold"�6�   �� 52      $��From:��6   $��Center=�6,   $��
113 30 0 0q�6P   $��	Agency FB)�6d   $��20(�6{   $��SemiBold"�6�   �� 53      $��To��6   $��Right=�6)   $��
180 30 0 0q�6L   $��	Agency FB)�6`   $��20(�6w   $��SemiBold"�6�   54      �� 55      $��2��6   $	 
Horizontal=�6*   $��90 0 0 0q�6C   .+�56      �� -   5        $��amountCurrency��56      $
��Left=�6a   $��Center=�57      $��	20 30 0 0q�68   $	��130��6K   $��30��6W   $��16(�6c   $��SemiBold"�58      $��	Agency FB)�6,   6F   �� 59      -   5        $��cbFromCurrency��59      $��Center=�65   $��	85 30 0 0q�6W   $	��130��6j   $��30��6v   
 �� MaxDropDownHeight$	
 150��5:      $��	Agency FB)�6/   $��SemiBold"�6F   6^   "  FontAwesome.WPF.ImageAwesome  5;         Icon$ Exchange=�6&      
Foreground
 �   �$��25��6I   $��	40 31 0 0q�6U   6k   �� 5<      -   5        $��cbToCurrency��5<      $
��Left=�63   $��Center=�6U   $��	30 30 0 0q�5=      $	��130��6*   $��30��66   $	
 150��6B   $��	Agency FB)�6Z   $��SemiBold"�6q   6�   5>      �� 5?      $��3��6   $	 
Horizontal=�6*   $��Center=�6C   $	��Top=�6`   $��0 8 0 0q�6x   .+�5@      �� -   5        $��Convert��5@      $��	Agency FB)�6B   $��Convert��6Y   $��SemiBold"�5A      $��0 0 10 0q�6+   $	��100��6=   $��30��6I      ButtonRound#��[  5B      ��5C      �� 5D      .��5E   "   � $ 	OrangeRed��6/   $	 0.0Q�6A   � 5F   "   $ Orange��6/   $
 0.50Q�6>   5G      5I      �� 5J      -   5        $��Clear��5J      $��	Agency FB)�6>   $��Clear��6U   $��SemiBold"�5K      $��10 0 0 0q�6+   $	��100��6=   $��30��6I   #��[  5L      ��5M      �� 5N      .��5O   "   � $ 	OrangeRed��6/   $	 0.0Q�6A   � 5P   "   $ Orange��6/   $
 0.50Q�6>   5Q      5S      5T      �� 5U      $��4��6   $	 Vertical=�6*   $��Center=�6A   $��Center=�6\   .+�5V      �� $��/Images/Logo.png��6   $��86��66   $��86��6B   �� 5W      $��4��6   $��Iran Blizzard Store��6)   $��	Agency FB)�6G   $��16(�6^   $	��Top=�5X      $��Center=�6,   5Y      5Z      5\      �� 5]   
   -	   5        $��tbMaster��5]      $��Currency Master��6"   .��5^      � .+�5_      �� $��Currency Converter��6   $	��780��65   $��Center=�6A   $��30(�5`      
��� E��$
��Bold"�6:   $��	Agency FB)�6L   $��	7,0,7,451q�6c   �� 5a      $��Center=�6   $	��123��69   $��0,60,0,0q�6F   
���   �$	��Top=�6g   $	��686��6   ��5b      �� 5c      $	 0,0&�6.   $	 1,0&�6?   .��5d      � $ 	OrangeRed��6+   $	 0.0Q�6=   � 5e      $ Orange��6+   $
 0.50Q�6:   5f      5h      �� 5i      -
   5        $��	txtAmount��5i      $
��Left=�6+   $��Center=�5j      $��195,108,420,353q�68   $��16(�6Q   $��SemiBold"�5k      $��	Agency FB)�6,   �� 5l      -   5        $��txtCurrencyName��5l      $
��Left=�61   $��Center=�5m      $��420,108,195,353q�67   $��16(�6P   $��SemiBold"�5n      $��	Agency FB)�6+   �� 5o      $��Enter Amount��6   $
��Left=�6/   $��
195,77,0,0q�6J   $	��Top=�6^   $	��179��6v   �� 5p      $��Currency Name��6   $
��Left=�60   $��
420,77,0,0q�6K   $	��Top=�6_   $	��179��6w   �� 5q      -   5        $��btnSave��5q      $
��Save��6(   $
��Left=�6M   $��256,200,0,0q�6h   $	��Top=�6}   $��30��5r      $	��120��6%   #��[  61   ��5s      �� 5t      .��5u      � $ 	OrangeRed��6+   $	 0.0Q�6=   � 5v      $ Orange��6+   $
 0.50Q�6:   5w      5y      �� 5z      -   5        $��Cancel��5z      $
��Left=�6B   $��420,200,0,0q�6]   $	��Top=�6r   $��30��5{      $	��120��6%   #��[  61   ��5|      �� 5}      .��5~      � $ 	OrangeRed��6+   $	 0.0Q�6=   � 5      $ Orange��6+   $
 0.50Q�6:   5�      5�      &   System.Windows.Controls.DataGrid  5�      -   5        $��dgvCurrency��5�         AutoGenerateColumns$ False��6.   
������    CanUserAddRows$ False��6c      SelectionUnit$
 Cell=�5�   S   "   VerticalScrollBarVisibility$
 Auto=�6h   $��160,253,160,55q�5�         Columns 5�      0  *System.Windows.Controls.DataGridTextColumn  5�      -   5        Id��,  &System.Windows.Controls.DataGridColumn   Header$ Id��5�   9      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6E      CanUserResize$ False��6Q      
Visibility$ Hidden=�5�   -   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6A   ��  �� Path$ Id�5�      4  .System.Windows.Controls.DataGridTemplateColumn  5�      $  ��61   $ 70 6;      
IsReadOnly$
 True��6F      DisplayIndex$ 0��6X      CellTemplate 5�      �� 5�   "   .R�5�   &   ��  ��Name$ Revise��6]   $��/Images/edit.png��6,   $��20��6F   $��20��6Q   6]   5�   #   5�        5�      $  ��61   $ 70 6;   $
 True��6F   $ 1��6X    5�      �� 5�   "   .R�5�   &   �� $ Delete��6p   $��/Images/delete.png��6,   $��20��6H   $��20��6S    � ToolTip$ Delete��6_   6p   5�   #   5�        5�      -   5        
Amount��$ Amount��5�   =   $	 100 6M   $ False��6Y      CanUserReorder$ False��5�   -    6D   �� $ Amount�  5�      -   5        CurrencyName��$ Currency Name��5�   D   $	 180 6[   $ False��6g   $ False��5�   -    6D   �� $ CurrencyName�5�      5�      5�      5�      ��5�      �� 5�   
   .��5�      � $ 	#FF53D7D5��6   $	 0.0Q�6-   � 5�      $ White��6   $
 0.50Q�6)   5�      5�      