   M S B A M L   `   `   `  ����H  DProjectPRN212, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:ProjectPRN212ProjectPRN212  5   	        ProjectPRN212.EdipQuestion   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:ProjectPRN212     5   	   _ [MaterialDesignThemes.Wpf, Version=5.1.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � WindowStartupLocation$  CenterScreen=�5       � WindowStyle$
 None=�6?    � AllowsTransparency$
 True��6R    � Title$ EdipQuestion��5	   	   $	��800��6   $
��1146��6+   .��5
      �  � RowDefinitions 5   
   �� 5      $
��auto �6   6,   �� 5      6   .+�5   
   � $��0��6   .+�5      (  "MaterialDesignThemes.Wpf.ColorZone     Mode$ PrimaryLight=�6'   .��5      ]� .+�5      �� $��Right=�6!    �� Orientation$ 
Horizontal=�68   
������  � 	Resources 5       �� 
TargetType	 �� Property
 �� Value��%�   '��       �� 5      " ��6$   .�5   "   �� 	 � ��$
 2 4 2 4q�6;   6M   �� 5   "   	 � ��$
 40��6:   6G   5      5      .+�5      �� -   5         ��Name$ btnMinimized��5   3    � ToolTip$ 	Thu nhỏ��6!    c� OverflowMode$ AsNeeded=�6J   
���"�"�.��5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ WindowMinimize=�66   5      �� 5      -   5        $ btnMaximized��5   4   $ 	Phóng to��6!   $ AsNeeded=�6J   
���"�"�.��5        $ WindowMaximize=�66   5      �� 5      -   5        $ btnClose��5   0   $ Đóng��6!   $ AsNeeded=�6B   
��� E��.��5         $ WindowClose=�66   5!      5"      �� 5$      $ 
Horizontal=�6!   $
��Left=�6:   .+�5%      �� $��16,0,0,0q�6$   $��Center=�66   $��Thi Thử bằng Lái xe��6Q   $��17(�6l   5&      5'      5(      5)      � 5*   
   $��1��6    5+      �� 5,      $
��auto �6    60   �� 5-      6"   .+�50      � $��0��6   .+�51      � $��Stretch=�6   
������  52      ��%�   '��       �� 53      " ��6    .�54      �� 	 � ��$
 2 4 2 4q�67   6I   �� 55      	 � ��$	
 110��66   6D   �� 56      	 � ��$
 50��67   6D   �� 57      	 � ��

 �����6O   58      59       � ColumnDefinitions 5:      �� 5;      6-   �� 5<      6-   �� 5=      6-   .+�5?      �� -   5        $ btnHome��5?      $��0��6.   $
 Home��6>   .��5@      �  5A      �� 5B   "   62   �� 5C   "   62   .+�5E      � $��0��6#   .+�5F   "     $��Center=�6:   $
 Home=�6W   5G      � 5H      $��1��6#   .+�5I   "   �� $��Center=�6,   Home6O   5J      5K      5L      �� 5M      -   5        $ btnEdipUser��5M      $��1��62   $ 	Edit User��6B   .��5N      �  5O      �� 5P   "   62   �� 5Q   "   62   .+�5S      � $��0��6#   .+�5T   "     $��Center=�6:   $
 User=�6W   5U      � 5V      $��1��6#   .+�5W   "   �� $��Center=�6,   	Edit User6T   5X      5Y      5Z      �� 5\      -   5        $ 	btnLogout��5\      $��2��60   $ Edit Question��6@   .��5]      �  5^      �� 5_   "   62   �� 5`   "   62   .+�5b      � $��0��6#   .+�5c   "     $��Center=�6:   $ Logout=�6W   5d      � 5e      $��1��6#   .+�5f   "   �� $��Center=�6,   Logout6Q   5g      5h      5i      5j      5k      � 5l      $��1��6    5m      �� 5n      $
��auto �6$   64   �� 5o      $
��auto �6$   64   �� 5p      $
��auto �6$   64   �� 5q      6&    5s      �� 5t      $
��380* �6'   66   �� 5u      $
��193* �6'   66   .+�5w      � $��0��6   $��2��6$   .+�5x      �� $	��300��6   $	��100��6(   $H��BD:\Desktop\NET\ProjectPRN212\ProjectPRN212\PRN212\EditQuestion.png��65   5y      �� 5z      $��1��6   ���	#FFACA2A2$��1q�6>    �� CornerRadius$ 10��6R   $��5q�6d   ._�5|      �  5}      �� 5~      $	��31* �6(   67   �� 5      $	��49* �6(   67   �� 5�      $	��12* �6(   67   �� 5�      $��0* �6(   66   .+�5�      � $��5,5,5,5q�6    $��0��61   .+�5�      �� $��0 0 32 0q�6    $��
Question: ��62   �� 5�      -   5         ��Name$ txtQuestion��5�   "   $	��730��67   $��30��6C   $��15(�6O    �� TextAlignment$ Center=�6]   $��Center=�6t   $��Center=�6�   5�      � 5�      $��1��6   $��5,5,5,5q�6(    5�      �� 5�      $
��Auto �6,   �� 5�      $��20 �6,   �� 5�      $
��Auto �6,    5�      �� 5�      $
��Auto �6/   �� 5�      $	��300 �6/   �� 5�      $��30 �6/   �� 5�      $
��Auto �6/   �� 5�      $	��300 �6/   .+�5�      �� $��0��6    $��0��6-   $��0 0 10 0q�6=   $��	Answer1: ��6O   $��Center=�6c   �� 5�      -   5        $ 
txtAnswer1��5�   "   $��0��66   $��1��6C   $	��240��6S   $��30��6_   $��15(�6k   $ Center=�6y   $��Center=�6�   $��Center=�6�   $��0 0 30 0q�6�   �� 5�      $��0��6    $��3��6-   $��0 0 10 0q�6=   $��	Answer2: ��6O   $��Center=�6c   �� 5�      -	   5        $ 
txtAnswer2��5�   "   $��0��66   $��4��6C   $	��240��6S   $��30��6_   $��15(�6k   $ Center=�6y   $��Center=�6�   $��Center=�6�   $��0 0 30 0q�6�   �� 5�      $��2��6    $��0��6-   $��0 0 20 0q�6=   $��	Answer3: ��6O   $��Center=�6c   �� 5�      -
   5        $ 
txtAnswer3��5�   "   $��2��66   $��1��6C   $	��240��6S   $��30��6_   $��15(�6k   $ Center=�6y   $��Center=�6�   $��Center=�6�   $��0 0 30 0q�6�   �� 5�      $��2��6    $��3��6-   $��0 0 10 0q�6=   $��	Answer4: ��6O   $��Center=�6c   �� 5�      -   5        $ 
txtAnswer4��5�   "   $��2��66   $��4��6C   $	��240��6S   $��30��6_   $��15(�6k   $ Center=�6y   $��Center=�6�   $��Center=�6�   $��0 0 30 0q�6�   5�      � 5�      $��5,5,5,5q�6    $��2��61   .+�5�      �� $��CorrectAnswer: ��6    �� 5�      -   5         ��Name$ cbCorrectAnswer��5�   #   $��	0 0 165 0q�6<   $	��150��6O   .@�5�   "   �� $��Answer 1��6/   
 � Tag$ 1��6B   �� 5�   "   $��Answer 2��6/   $ 2��6B   �� 5�   "   $��Answer 3��6/   $ 3��6B   �� 5�   "   $��Answer 4��6/   $ 4��6B   5�      �� 5�      $��0 0 28 0q�6    $��	License: ��62   �� 5�      -   5        $ 	cbLicense��5�   /   $	��150��6#   5�      �� 5�      -   5         ��Name$
 lbId��5�       $y�	Collapsed=�6.   5�      5�      5�      �� 5�      $��1��6   $��1��6&   ���	#FFA7A1A1$��1q�6N   $ 10��6b   $��5q�6t   ._�5�      � .+�5�      �� .+�5�      �� -   5         ��Name$ 
igQuestion��5�       $	��250��64   $	��100��6@   5�      �� 5�      -   5        $��20q�5�   !   $��25��6-   $��Choose image question��69   6Y   � 5�      $��Center=�6$   .+�5�      �� -   5        $ btnadd��5�   %   $
��10 0q�65   ���	#FF9EDA9E$��Add Question��6Z   $��25��6q   $	��100��6}   6�   �� 5�      -   5        $ 	btnUpdate��5�   %   $
��10 0q�68   ���	#FF9EDA9E$��Update Question��6]   $��25��6w   $	��100��6�   6�   �� 5�      -   5        $ 	btnDelete��5�   %   $
��10 0q�68   
���  ��$��Delete Question��6W   $��25��6q   $	��100��6}   6�   5�      5�      5�      5�      � 5�      $��10q�6   $��2��6#   $��2��60    5�      �� 5�      $
��322* �6+   6:   �� 5�      $
��483* �6+   6:   �� 5�      $
��269* �6+   6:   �� 5�      $	��53* �6+   .+�5�      �� 
���  ��$
��Bold"�6-   $��0��6?   $	��200��6O   $
��Left=�6[   $��50��6v   $��20(�6�   $��2��6�   $��	122,0,0,0q�6�   .��6�   Tìm Kiếm Câu Hỏi:6�   � 5�      $��1��6    5�      �� 5�      $��2* �6/   6<   �� 5�      $��* �6/   6;   .+�5�      �� -   5        $ txtSearchByName��5�   k   $
��auto��6"   $��0��6/   $��Stretch=�6?   $��15(�6]   $ Center=�5�      $��Center=�60   $��Center=�6T   6x   �� 5�      -   5        $ cbTypeOfLicense��5�   e   $��1��6#   $��	30 0 20 0q�63   $��Stretch=�6G   $��Center=�5�      $��Center=�6=   5�      5�      �� 5�      -   5        $ 	btnSearch��5�      $��30,0,0,0q�60   $
��Left=�6B   $	��100��6]   $��2��6i   $ Search��6y   .��5�      �  5�      �� 5�   "   62   �� 5�   "   62   .+�5�      � $��0��6#   .+�5�   "     $��Center=�6:   $ Search=�6W   5�      � 5�      $��1��6#   .+�5�   "   �� $��15(�6,   $��Center=�6:   Search6_   5�      5�      5�      5�      � 5�      $��3��6   $��2��6$   .+�5�      #  MaterialDesignThemes.Wpf.Card  .��5�      &   System.Windows.Controls.DataGrid  -   5          Name$ dgListQuesTionAll��5�   #      AutoGenerateColumns$ False��6>      Columns 5�      0  *System.Windows.Controls.DataGridTextColumn  5�   "   ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 65      Header$ Question��6?   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6Q   �� *
Question+   ElementStyle 5�   &   �� 5�   *   " ��60   .�5�   .   �� 	 � ��$

 Wrap=�6M   5�   +   5�   #     5�   "   $ 0.75* 65   $ Answer1��6C    6T   �� *	Answer1+ 5�   &   �� 5�   *   " ��60   .�5�   .   �� 	 � ��$

 Wrap=�6M   5�   +   5�   #     5�   "   $ 0.75* 65   $ Answer2��6C    6T   �� *	Answer2+ 5�   &   �� 5�   *   " ��60   .�5�   .   �� 	 � ��$

 Wrap=�6M   5�   +   5�   #     5�   "   $ 0.75* 65   $ Answer3��6C    6T   �� *	Answer3+ 5�   &   �� 5�   *   " ��60   .�5�   .   �� 	 � ��$

 Wrap=�6M   5   +   5  #     5  "   $ 0.75* 65   $ Answer4��6C    6T   �� *	Answer4+ 5  &   �� 5  *   " ��60   .�5  .   �� 	 � ��$

 Wrap=�6M   5  +   5	  #   4	  .System.Windows.Controls.DataGridTemplateColumn	  5
  "   $ * 69   $ Image��6C    	  CellTemplate 5  &   �� 5  *   .R�5  .   �� $	��165��6M   $	��100��6Y   ��64   �� *Image+6Y   5  +   5  #     5  "   $ CorrectAnswer��65   $
 0.5* 6n    6L   �� *CorrectAnswer+ 5  &   �� 5  *   " ��60   .�5  .   �� 	 �@��TextAlignment$
 Center=�6N   �� 5  .   	 � ��$

 Wrap=�6M   5  +      HeaderStyle 5  &   �� 5  *   =
  7System.Windows.Controls.Primitives.DataGridColumnHeader" 
 60   .�5  .   �� 	 � ��$
 Center=�6T   5  +   5  #   5     5      5!     5"     5#     5$     5&     