   M S B A M L   `   `   `  ����c  _WPF Project - Currency Converter 3 - API, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullc6clr-namespace:WPF_Project___Currency_Converter_3___API(WPF_Project___Currency_Converter_3___API  5   	   9    3WPF_Project___Currency_Converter_3___API.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/  5   	   Blocal6clr-namespace:WPF_Project___Currency_Converter_3___API  5   	     � Title$  
MainWindow��5	   	   $	��546��6   $	��800��6)   .��5
      �  � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $	��100 �6   �� 5      $	��150 �6   �� 5      $��50 �6   �� 5      $	��200 �6   .+�5   
   �� $��2��6    �� CornerRadius$ 8��6   $��5q�6/   $��	50,5,50,5q�6C   ��5      �� 5      .��5      �  � Color$ MediumVioletRed��6#    � Offset$	 0.0Q�6;   � 5      $ 
DarkOrange��6#   $
 0.50Q�66   5      ._�5      �� ��5      �� 5       �� 
StartPoint$	 0,0&�6*    �� EndPoint$	 1,0&�6;   .��5      � $ 	OrangeRed��6'   $	 0.0Q�69   � 5      $ Orange��6'   $
 0.50Q�66   5      5       5!      �� 5"   
   $	��780��6   $��50��6!    �� Orientation$ 
Horizontal=�6-   .+�5#      �� $��Currency Converter��6   $	��780��61   $��Center=�6=   $��Center=�5$      $��30(�66   
��� E��$
��Bold"�6[   $��	Agency FB)�6m   5%      �� 5&   
   $��1��6   .+�5'      �� $��Converted Currency��6   $��Center=�61   $��	Agency FB)�6N   $��20(�6e   $��SemiBold"�6s   �� 5(      -   5        $��lblCurrency��5(      $��40��6'   $	��780��63   $��Center=�6?   $��Center=�5)      $��20(�66   $��	Agency FB)�6D   6^   5*      �� 5+   
   $��2��6   $ 
Horizontal=�6"   $��90 0 0 0q�6;   .+�5,      �� $��Enter Amount��6   $
��Left=�6+   $��	20 30 0 0q�6M   $��	Agency FB)�6`   $��20(�6w   $��SemiBold"�6�   �� 5-      $��From:��6   $��Center=�6$   $��
113 30 0 0q�6H   $��	Agency FB)�6\   $��20(�6s   $��SemiBold"�6�   �� 5.      $��To��6   $��Right=�6!   $��
180 30 0 0q�6D   $��	Agency FB)�6X   $��20(�6o   $��SemiBold"�6}   5/      �� 50   
   $��2��6   $ 
Horizontal=�6"   $��90 0 0 0q�6;   .+�51      �� -   5        $��amountCurrency��51      $
��Left=�6Y   $��Center=�52      $��	20 30 0 0q�68   $	��130��6K   $��30��6W   $��16(�6c   $��SemiBold"�53      $��	Agency FB)�6,   6F   �� 54      -   5        $��cbFromCurrency��54      $��Center=�6-   $��	85 30 0 0q�6O   $	��130��6b   $��30��6n    �� MaxDropDownHeight$	 150��55      $��	Agency FB)�6/   $��SemiBold"�6F   6^   "  FontAwesome.WPF.ImageAwesome  56      	   Icon$	 Exchange=�6   
   
Foreground

 �   �$��25��6A   $��	40 31 0 0q�6M   6c   �� 57      -   5        $��cbToCurrency��57      $
��Left=�6+   $��Center=�6M   $��	30 30 0 0q�58      $	��130��6*   $��30��66   $	 150��6B   $��	Agency FB)�6Z   $��SemiBold"�6q   6�   59      �� 5:   
   $��3��6   $ 
Horizontal=�6"   $��Center=�6;   $	��Top=�6X   $��0 8 0 0q�6p   .+�5;      �� -   5        $��Convert��5;      $��	Agency FB)�6:   $��Convert��6Q   $��SemiBold"�5<      $��0 0 10 0q�6+   $	��100��6=   $��30��6I      ButtonRound#��[  5=      ��5>      �� 5?      .��5@      � $ 	OrangeRed��6'   $	 0.0Q�69   � 5A      $ Orange��6'   $
 0.50Q�66   5B      5D      �� 5E      -   5        $��Clear��5E      $��	Agency FB)�66   $��Clear��6M   $��SemiBold"�5F      $��10 0 0 0q�6+   $	��100��6=   $��30��6I   #��[  5G      ��5H      �� 5I      .��5J      � $ 	OrangeRed��6'   $	 0.0Q�69   � 5K      $ Orange��6'   $
 0.50Q�66   5L      5N      5O      �� 5P   
   $��4��6   $ Vertical=�6"   $��Center=�69   $��Center=�6T   .+�5Q      �� $��/Images/Logo.png��6   $��86��6.   $��86��6:   �� 5R      $��4��6   $��Iran Blizzard Store��6!   $��	Agency FB)�6?   $��16(�6V   $	��Top=�5S      $��Center=�6,   5T      5U      ��5V      �� 5W   
   .��5X      � $ 	#FF53D7D5��6   $	 0.0Q�6-   � 5Y      $ White��6   $
 0.50Q�6)   5[      5]      