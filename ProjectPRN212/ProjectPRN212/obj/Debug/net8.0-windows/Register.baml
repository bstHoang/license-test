   M S B A M L   `   `   `  ����H  DProjectPRN212, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:ProjectPRN212ProjectPRN212  5   	       ProjectPRN212.Register   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:ProjectPRN212     5   	     � WindowStartupLocation$  CenterScreen=�5   "    � WindowStyle$
 None=�6G    � AllowsTransparency$
 True��6Z   
������  � Title$ Login��5   	   $	��500��6   $	��800��6$   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��* �6   �� 5      $
��1.5* �6   .+�5   
   �� -   5         ��Name$ lblClose��5      $
��Bold"�6N   $��50��6`   $��30(�6l   $��X��6z   $��1��6�    K� ZIndex$ 1��6�      btnClose#��[  6�   �� 5   
    �� CornerRadius$ 	10 0 0 10��6   ��5      �� 5       �� 
StartPoint$	 0,0&�6&   	 �� EndPoint$		 1,1&�67   .��5      � 
 � Color$	
 Red��6#    � Offset$ 0Q�6/   � 5      $
 White��6#   $ 1Q�61   5      ._�5      � .+�5      �� .+�5      �  � Points �    -1��� ;X�����	#FFF314146=   � 5      ' �    �� �� ���� ��
�����	#FFF314146B   A� 5      $��250 450 0 0q�6   $��40��63   $��40��6>   ���	#FFF314146K   A� 5      $��
50 400 0 0q�6   $��40��62   $��40��6=   ���	#FFF314146J   5      �� 5      $��Center=�6   .+�5      �� $��Sign In��6      	titleText#��[ 6/   �� 5      $Z��TNếu bạn đã có Account thì có thể đăng nhập vào trang để thi thử��6      
normalText#��[ 6g    J� Opacity$	 0.8Q�6�   $��20 30q�6�   �� 5       -   5         ��Name$ 	btnSignIn��5       $��Sign In��60    
 button#��[ 6B   6b   5!      5"      5#      �� 5$   
   ���#ffffff$��1��6&   $ 	0 10 10 0��66   ._�5%      �� $��Center=�6   $	��400��64   .+�5&      �� $��Sign Up��6   #��[ 6+   
���  ��6N   � 5'      $��20q�6   $��Center=�6#   $��Center=�6@    � RowDefinitions 5(      �� 5)      $
��Auto �6(   �� 5*      $
��Auto �6(   �� 5+      $
��Auto �6(   .+�5/      �� $��1q�6   ���#acb0af$ 5��6G   $��0��6X   $��61,7,-42,13q�6e   ._�50      � $��5q�6    51      �� 52   "   $
��Auto �63   �� 53   "   $��* �63   .+�55      �� $
��Bold"�6$   $��20(�66   $��40��6D   $��Center=�6P   $��Account��6k   $��-142,0,294,0q�6}   �� 56      -   5         ��Name$ txtEmail��56   C   $
��autoq�6&   $��17(�65   $��	10,9,10,0q�6V   $��0q�6i   57      58      �� 5;      $��1q�6   ���#acb0af$ 5��6G   $��1��6X   $��61,7,-42,13q�6e   ._�5<      � $��5q�6    5=      �� 5>   "   $
��Auto �63   �� 5?   "   $��* �63   .+�5A      �� $
��Bold"�6$   $��20(�66   $��40��6D   $	��100��6P   $	��Top=�6\   $��Password��6t   $��-142,5,257,0q�6�    J� RenderTransformOrigin$ 0.725,0.322&�6�   G� 5B      -   5         G�Name$ txtPassword��5B   G   $
��autoq�6*   $��17(�69   $��	8,10,10,0q�6\   $��0q�6o   $��2��6�   5C      5D      �� 5E      $��1q�6   ���#acb0af$ 5��6G   $��2��6X   $��61,10,-42,9q�6e   ._�5F      � $��5q�6    5G      �� 5H   "   $
��Auto �63   �� 5I   "   $��* �63   .+�5K      �� $
��Bold"�6$   $��20(�66   $��40��6D   $	��135��6P   $	��Top=�6\   $��Confirm Pass��6t   $��-145,1,260,0q�6�   $ 0.725,0.322&�6�   G� 5L      -   5        $ txtConfimpass��5L   G   $
��autoq�6*   $��17(�69   $��	8,10,10,0q�6^   $��0q�6q   $��2��6�   5M      5N      �� 5P      -   5        $ 	btnSignUp��5P      $��Sign Up��61   $��Center=�6C   $��2��6`     
mainbutton#��[ 6m   $��
0,86,0,-66q�6�   6�   5Q      5U      5V      5W      5X      