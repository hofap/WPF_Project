   M S B A M L   `   `   `  ����  GUI    GUI.MainWindow   5   	   9toolkit-http://schemas.microsoft.com/wpf/2008/toolkit  \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   "   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   �   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     6'    � Title$  	Phonebook��6	   $
��Left=�6    � 
ResizeMode$ NoResize=�66    � WindowStartupLocation$ CenterScreen=�6L    � WindowStyle$ SingleBorderWindow=�6q   $��Stretch=�6�   $��Center=�6�   $	��358��6n  $	��672��6{  $	��358��6�  $	��672��6�   � 	Resources 5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $  Resources\GlassButton.xaml?�6%   %    5      .��5      � $	��644��6    � RowDefinitions 5   
   �� 5      $��36 �6   �� 5      $
��283* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5        $��dgContactsDisplay��5   /   	   HeadersVisibility$	 Column=�6   $��
12,6,12,12q�6H   
   CanUserReorderColumns
 .     AutoGenerateColumns .     CanUserResizeRows .     
IsReadOnly .    RowDetailsVisibilityMode$ 	Collapsed=�6�      SelectionMode$ Extended=�6�   $��1��6   $��3��6  $��Stretch=�6!     AlternatingRowBackground
 �����$��2q�6�  ���	#FFBCC6D7   RowStyle 5      �� 5       �� 
TargetType)  #System.Windows.Controls.DataGridRow"  6    �� Triggers 5      P� 5       P� Property �@J�IsMouseOver P� Value . . �5      ��  �� Property � �� �� Value
 �����6P   5      5!         Columns 5$      0  *System.Windows.Controls.DataGridTextColumn  5%      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6<      Width5  /System.Windows.Controls.DataGridLengthConverter$ 50 6H   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *ID+6H     5&      $ 
First Name��6C   $ * 6W    6%   �� *	FirstName+6W     5'      $ 	Last Name��6B   $ * 6U    6%   �� *
LastName+6U     5(      $ 
Group Name��6C   $ * 6W    6%   �� *	GroupName+6W      RowDetailsTemplate 5*      �� 5+      .R�5,      �  � ShowGridLines .   5-      �� 5.      $��* �6,   �� 5/      $��* �6,    51      �� 52      $��50 �6/   �� 53      $��* �6/   .+�55      �� $��0��6    $��2��60   $��40��6A   $��/Images/phone.png��6L   �� 56      $��1��6    $��0��60   $��Phone Numbers:��6=   $��12(�6V   $
��Bold"�6d   �� 57      $��1��6#   $��1��60   $��0q�6`   ��6A   �� *Phones+��58      �� 59   "   ��5;      �� 5<   "   .R�5=   &   ��  �� Orientation$ 
Horizontal=�61   .+�5>   *   �� $��lblPhoneNumber��6N   ��60   �� *
TypeName+6N   �� 5?   *   $��-��60   �� 5@   *   $��lblPhoneType��6L   ��60   �� *Number+6L   5A   '   5B   #   5D      5E      5F      5H      �� 5I   
   -   5        $��btnAdd��5I   D   ���	#FF2C3D5B$	��Add��6(   $��24(�66   $��36��6g   $��Stretch=�6s   ��5J      �� 5K       �� EndPoint$ 0.5,1&�6&     �� 
StartPoint$  0.5,0&�67   .��5L      � ! � Color$! 	#FFFCED3B��6#   " � Offset$" 0Q�65   � 5M      $! 	#EEFFFFD0��6#   $" 0.484Q�65   5N      5P      �� 5Q   
   -   5        $��	btnUpdate��5Q   G   ���	#FF2C3D5B$��Update��6(   $��24(�69   $��1��6p   $��2��6�   $��	0,0,214,0q�6�   ��5R      �� 5S      $ 0.5,1&�6&   $  0.5,0&�67   .��5T      � $! 	#FFFCED3B��6#   $" 0Q�65   � 5U      $! 	#EEFFFFD0��6#   $" 0.484Q�65   5V      5X      �� 5Y   
   -   5        $��	btnDelete��5Y   G   ���	#FF2C3D5B$��Delete��6(   $��24(�69   $��2��6p   $��1,0,0,0q�6�   ��5Z      �� 5[      $ 0.5,1&�6&   $  0.5,0&�67   .��5\      � $! 	#FFFCED3B��6#   $" 0Q�65   � 5]      $! 	#EEFFFFD0��6#   $" 0.484Q�65   5^      5`      5a      ��5b      �� 5c   
   $ 0.5,1&�6   $  0.5,0&�6/   .��5d      � $! 
WhiteSmoke��6   $" 0Q�6.   � 5e      $! White��6   $" 0.626Q�6)   5f      5h      