   M S B A M L   `   `   `  ����I  EautoRepairShop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:autoRepairShop.ProductautoRepairShop.Product  5      (    "autoRepairShop.Product.ProductPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:autoRepairShop.Product     5        N� Title$  ProductPage��5	       � 	Resources 5
      ��%    5      .��5      � ��5   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ Black��6    � Offset$ 0Q�6-   � 5      $ 	#FF5A602D��6   $ 1Q�61   5       � RowDefinitions 5   
   �� 5      $��9* �6   �� 5      $	��41* �6    � ColumnDefinitions 5   
   �� 5      $
��161* �6   �� 5      $
��639* �6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��0��6.   $��1��6;   .+�5      �� $��
Поиск��6   $��Right=�6$   $��Center=�6@   $��
0 0 -370 0q�5      
�������$��20(�6?   �� 5      -   5        	 ��Name$	 search��5      ���	#FFE2D587$��4 4 4 4q�6>   
������ $��Right=�5    /   $��
0 0 -600 0q�5!      $��Center=�6*   $	��200��6E   5"      �� 5#      -   5        
 ��Name$
 btnAdd��5#      $��Добавить��6%      btn#��[  68   6U   �� 5$      -   5        $
 	btnDelete��5$      $��Удалить��6(   #��[  6:   6W   5%      �� 5&   
   $��1��6   .+�5'      �� -   5        $
 btnReno��5'      $��Renault��6&   #��[  68   6U   �� 5(      -   5        $
 btnLada��5(      $
��Lada��6&   #��[  65   6R   �� 5)      -   5        $
 	btntoyota��5)      $��Toyota��6(   #��[  69   6V   �� 5*      -   5        $
 btnRef��5*      $��Обновить��6%   #��[  68   $��	0 100 0 0q�6U   6h   5,      &   System.Windows.Controls.DataGrid  5-   
   -   5          Name$ dataGrid��5.   0      AutoGenerateColumns .  
���   �  dataGrid#��[ 5-   B   $��1��5.      $��1��6#      
IsReadOnly .    Columns 5/      0  *System.Windows.Controls.DataGridTextColumn  50      ,  &System.Windows.Controls.DataGridColumn   Header$ Наименование��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 300 51   B      FontSize$ 20Q�6N   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *
nameProd+   ElementStyle 52      �� 53       �� 
TargetType" ��6    .�54      ��  �� Property � �� �� Value$
 Wrap=�6=   6L   55      57        58      $	 200 6%   $ Цена��61   $ 20Q�6s    6?   �� *cost+ �� StringFormat$ {0:0.00}��6s     59      $	 150 6%   $ Количество��61   $ 20Q�6b    6E   �� *
quantity+6b     5:      $	 200 6%   $% Марка автомобиля��61   $ 20Q�6e    6K   �� *brand+6e   4  .System.Windows.Controls.DataGridTemplateColumn  5;         CellTemplate 5<      �� 5=      .R�5>      �� $��editBtn��6=   -	   5        $ ��Редактировать��5>   %   $	��150��6L   $��20(�6X   $��50��6f   ���	#FFE2D5875?   <   5@      5B      5D      5E      5F      