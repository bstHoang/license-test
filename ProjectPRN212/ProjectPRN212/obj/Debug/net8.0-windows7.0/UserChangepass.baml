   M S B A M L   `   `   `  ����H  DProjectPRN212, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:ProjectPRN212ProjectPRN212  5   	   "    ProjectPRN212.UserChangepass   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:ProjectPRN212     5   	   _ [MaterialDesignThemes.Wpf, Version=5.1.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � WindowStartupLocation$  CenterScreen=�5   	    � WindowStyle$
 None=�6.    � AllowsTransparency$
 True��6A    � Title$ UserChangepass��5	   	   $	��420��6    $	��584��6-   .��5
      � .+�5   
   �� .+�5      �� .+�5      (  "MaterialDesignThemes.Wpf.ColorZone     Mode$ PrimaryLight=�6+   .��5      ]� .+�5      �� $��Right=�6%    �� Orientation$ 
Horizontal=�6<   
������  � 	Resources 5       �� 
TargetType �� Property	 �� Value��%�   '��       �� 5   "   " ��6(   .�5   &   ��  � ��$	 2 4 2 4q�6?   6Q   �� 5   &    � ��$	 40��6>   6K   5   #   5      .+�5      �� -   5        
 ��Name$
 btnMinimized��5   7    � ToolTip$ 	Thu nhỏ��6%    c� OverflowMode$ AsNeeded=�6N   
���"�"�.��5   "   '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ WindowMinimize=�6:   5      �� 5      -   5        $
 btnMaximized��5   8   $ 	Phóng to��6%   $ AsNeeded=�6N   
���"�"�.��5   "     $ WindowMaximize=�6:   5      �� 5      -   5        $
 btnClose��5   4   $ Đóng��6%   $ AsNeeded=�6F   
��� E��.��5   "     $ WindowClose=�6:   5      5      �� 5       $ 
Horizontal=�6%   $
��Left=�6>   .+�5!      �� $��16,0,0,0q�6(   $��Center=�6:   $��User change password��6U   $��17(�6q   5"      5#      5$      � 5%      $��	60 10 0 0q�6   $��Center=�6/   $
��Left=�6J   .+�5&      �� 
���  ��$��15(�6-   .��6;   
ID User:6E   �� 5'      -   5         ��Name$ lbUserId��5'      $
��Bold"�6.   $��15(�6@   6P   �� 5(      
���  ��$��15(�6-   .��6;   	Username:6F   �� 5)      -   5        $ 
lbUserName��5)      $
��Bold"�60   $��15(�6B   6R   5*      �� 5+      $	��250��6   ���	#FF27D7B8$��1q�6=    �� CornerRadius$ 10��6Q   ._�5-      �� $��Center=�6!   .+�5.      �� $��20(�6    $
��Bold"�6.   $��Old password: ��6@   6[   G� 5/      -   5         G�Name$ 	pbOldPass��5/   &   $��17(�69   $	��200��6G   6U   �� 50      $��20(�6    $
��Bold"�6.   $��New password: ��6@   6[   G� 51      -   5        $ pbPass��51   &   $��17(�66   $	��200��6D   6R   �� 52      $��20(�6    $
��Bold"�6.   $��Confirm password: ��6@   6_   G� 53      -   5        $ pbConfim��53   &   $��17(�68   $	��200��6F   6T   �� 54      -	   5        $
 btnChangePass��54   3   $
��Bold"�6!   ���	#FFBBEEE5$��30q�6a   ���	#FF564B4B$��15(�6�   $	��130��6�   $��30��6�   $��Change Password��6�   6�   55      56      57      �� 58      -
   5        $
 btnback��58   C   $��Right=�6   $
��Bold"�61   
���  ��$��20q�6e   ���	#FF564B4B$��20(�6�   $	��130��6�   $��40��6�   $
��Back��6�   6�   59      5:      5;      