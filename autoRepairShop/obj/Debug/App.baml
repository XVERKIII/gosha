   M S B A M L   `   `   `  ����I  EautoRepairShop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:autoRepairShopautoRepairShop  5          autoRepairShop.App   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      .localclr-namespace:autoRepairShop     5        �� 	Resources  5       �� 
TargetType   btn �� Property �� Value �� EndPoint �� 
StartPoint � Color � Offset&   System.Windows.Controls.DataGrid  dataGrid=  7System.Windows.Controls.Primitives.DataGridColumnHeader)  #System.Windows.Controls.DataGridRow ! DataGridRow.Normal.Background �� 
TargetType	 ��Name
 J� SnapsToDevicePixels � UseLayoutRounding?  9System.Windows.Controls.Primitives.SelectiveScrollingGrid � ColumnDefinitions � RowDefinitions?  9System.Windows.Controls.Primitives.DataGridCellsPresenter   
ItemsPanelA  ;System.Windows.Controls.Primitives.DataGridDetailsPresenter   DetailsVisibility$   SelectiveScrollingOrientation;  5System.Windows.Controls.SelectiveScrollingOrientation   Vertical �� ConverterParameter#   RowDetailsScrollingConverter �� 	Converter �� RelativeSource �� AncestorType:  4System.Windows.Controls.Primitives.DataGridRowHeader7	  1System.Windows.Controls.DataGridHeadersVisibility
 	  Row!   HeadersVisibilityConverter �� Triggers P� Property P� Value $  DataGridRow.MouseOver.Background # DataGridRow.Selected.Background*
  $System.Windows.Controls.DataGridCell �� Triggers  ComboBoxToggleButton �� CornerRadius F�Name  ComboBoxTextBox��%X  &	        '�� �    '�� 8    &	     '  k    '  `    7  7  7  '
  8    &	 �    &	 �    �� 5   
   " ��6   .�5      ��  � ��
 �����6+   �� 5	       � ��
 ���� 6+   �� 5
       � ��$	 150��6&   �� 5       � ��$ 50��6'   �� 5       � ��$ 20(�6)   �� 5       � ��$ 4 4 4 4q�60   �� 5       � �� 5      �� 5      $ 0.5,1&�6*   $ 0.5,0&�6;   .��5      � $ Black��6'   $ 0Q�65   � 5      $ 	#FFAEB92C��6'   $ 1Q�69   5      5      5      �� 5   
   " ��6   .�5      ��  � ��
 �����6+   �� 5       � ��$ 20(�6)   5      �� 5   
   " ��6   .�5      ��  � ��$ 40��6'   �� 5       � ��$	 300��6&   �� 5       � ��$ 20(�6)   �� 5       � ��$ Center=�64   �� 5        � ��$ Center=�62   �� 5!       � �� �	#FFE2D5876,   �� 5"       � ��$
 10 0q�6(   �� 5#       �@�Cursor$ IBeam��6'   �� 5$       � ��
 ���� 6+   �� 5%       � ��
 �����6+   �� 5&       �@J�Opacity$ 20Q�6(   5'      �� 5)   
   "  6   .�5*      ��  �@ RowHeaderWidth$ 0Q�6/   �� 5+       �@ HeadersVisibility$ Column=�62   �� 5,        �@ HorizontalGridLinesBrush �	#00E9ECF169   �� 5-       �@ VerticalGridLinesBrush
 �   �67   �� 5.       �@�UseLayoutRounding . 62   �� 5/       �@J�SnapsToDevicePixels . 64   �� 50       �@ AutoGenerateColumns .  64   �� 51       �@ CanUserAddRows .  6/   �� 52       �@ CanUserReorderColumns .  66   �� 53       �@ CanUserResizeColumns .  65   �� 54       �@ CanUserResizeRows .  62   �� 55       �@ CanUserSortColumns . 63   �� 56       �@ GridLinesVisibility$
 None=�64   �� 57       �@ 
IsReadOnly . 6+   �� 58       �@ SelectionMode$ Extended=�6.   59      �� 5:   
   "  6   .�5;      ��  �@J�SnapsToDevicePixels . 64   �� 5<       � ��
 �   �6+   �� 5=       � ��$ 20(�6)   �� 5>       �@�Cursor$
 Hand��6'   �� 5?       � ��$ 40��6'   5A      �� 5B   
   "  6   .�5C      ��  � ��8   6+   �� 5D       �@J�SnapsToDevicePixels . 64   �� 5E       �@�UseLayoutRounding . 62   �� 5F       �@=�ErrorTemplate 69   Z� �� 5G       �@ ValidationErrorTemplate 5H      �� 5I      .R�5J      �� $��0,0,0,0q�6$   $��Center=�65   
���  ��$��!��6a   5K      5M      �� 5N       � ��$ Center=�64   �� 5O       � �� 5P      �� 5Q      "  6&   .R�5R      �� $	 
DGR_Border��6!   $��0,0,0,0q�65   #��z��5S      
 .  . ._�5U         5V   "   �� 5W   &   $
��Auto �67   �� 5X   &   $��* �67    5Z   "   �� 5[   &   $
��Auto �64   .+�5]   "     $��1��69   #��z 5^   5   #
 z
 5_   5     5`   "   $��1��6;   $��1��6H   #y�z 5f   7    5a   7   �� *AreRowDetailsFrozen+# Z # Z  �� "  5f   7     5g   "   $��2��64   $ Vertical=�6E   y�5h   0   �� *HeadersVisibility+# Z # Z  �� "  5l      5m       5n      P� 5o       �@J�IsMouseOver . . �5p   "   �� 8   � ��6?   5q      P� 5r       �@ 
IsSelected . . �5s   "   �� 8   � ��6?   5t      5v      5x      5y      �� 5z   
   " 
 6   .�5{      ��  � �� 5|      �� 5}      " 
 6&   .R�5~      �� $	 Bg��6!   
������� . ._�5      �� $��Center=�6/   $��Center=�6L   5�      5�      5�       5�      P� 5�       �@
 
IsSelected . . �5�      ��  � �� �	#FFE7060663   �� 5�       � ��
 �   �63   5�      5�      �� 5�   
   " d�67   .R�5�      �  5�      �� 5�      �� 5�      $��20 �6'   .+�5�      �� $	 Border��5�      $��2��5�      $ 5��5�      
������ $��2q�5�      �� 5�      $��0��5�      $ 0��5�      $��1q�5�      
������ $��1q�5�      F� 5�      $ Arrow��5�      $��1��5�      
�������$��Center=�5�      $��Center=�5�      =����        �    �� � 	= ��[ � z �� � z     � 	=  	= 	5�      5�      5�      �� 5�   
   " ��62   .R�5�      �� $	 PART_ContentHost��6   |�.  #��z��6A   5�      5�      5�      