   M S B A M L   `   `   `  ����H  DProjectPRN212, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:ProjectPRN212ProjectPRN212  5   	        ProjectPRN212.InforExamNow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:ProjectPRN212     5   	   _ [MaterialDesignThemes.Wpf, Version=5.1.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � WindowStartupLocation$  CenterScreen=�5       � WindowStyle$
 None=�66    � AllowsTransparency$
 True��6I    � Title$ InforExamNow��5	   	   $	��330��6   $	��350��6+   .��5
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
��Left=�6>   .+�5!      �� $��16,0,0,0q�6(   $��Center=�6:   $��Điểm thi của bạn��6U   $��17(�6m   5"      5#      5$      � 5%      $��	60 10 0 0q�6   $��Center=�6/   $
��Left=�6J   .+�5&      �� 
���  ��$��18(�6-   .��6;   	Username:6F   �� 5'      -   5         ��Name$ 
lbUserName��5'      $
��Bold"�60   $��18(�6B   .��6P   HezzWinGame6]   5(      �� 5)      $��	0 27 0 27q�6   $��Center=�60   .+�5*      �� -   5        $ lbSoCauDung��5*   9   $��Center=�6   $��60(�6N   $
��Bold"�6\   $��20/25��6n   � 5+      .+�5,      �� $��20(�6    $��Điểm của bạn là:��6.   �� 5-      -   5        $��lbScoure��5-       $��20(�60   
���  ��$
��Bold"�6O   $��9��6a   5.      5/      50      �� 51      -   5        $
 btnback��51   C   $��Right=�6   $
��Bold"�61   
���  ��$��20q�6e   ���	#FF564B4B$��20(�6�   $	��130��6�   $��40��6�   $
��Back��6�   6�   52      53      54      