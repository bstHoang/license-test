   M S B A M L   `   `   `  ����H  DProjectPRN212, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:ProjectPRN212ProjectPRN212  5   	   %    ProjectPRN212.DetailExamHistory   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:ProjectPRN212     5   	   _ [MaterialDesignThemes.Wpf, Version=5.1.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  ExamHistory��5	   	   $	��800��6   $
��1200��6*    � WindowStartupLocation$ CenterScreen=�5
   	    � WindowStyle$
 None=�6.    � AllowsTransparency$
 True��6A   .��5      � .+�5   
   (  "MaterialDesignThemes.Wpf.ColorZone     Mode$ PrimaryLight=�6#   .��5      ]� .+�5      �� $��Right=�6    �� Orientation$ 
Horizontal=�64   
������  � 	Resources 5       �� 
TargetType �� Property	 �� Value��%{   '��       �� 5      " ��6    .�5      ��  � ��$	 2 4 2 4q�67   �� 5       � ��$	 40��66   5      5      .+�5      �� -   5        
 ��Name$
 btnClose��5   ,    � ToolTip$ Đóng��6    c� OverflowMode$ AsNeeded=�6>   
��� E��.��5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ WindowClose=�62   5      5      �� 5      $ 
Horizontal=�6   .+�5      �� $��16,0,0,0q�6    $��Center=�62   $��Exam History��6M   $��17(�6a   5      5      5      �� 5   
   $��20q�6   .+�5       �� -   5        $��lbChuDe��5       $��40(�6#   $
��Bold"�61   
���  ��$��Center=�6T   $��Chủ Đề��6q   $��0 20 0 0q�6�   �� 5!      -   5         ��Name$ lbSoLuongCauHoi��5!      $��20(�6-   $��Center=�6;   $��	0 10 0 30q�6X   $��Số Lượng Câu Hỏi��6k   �� 5#      -   5         ��Name$ lvQuestions��5#      $	��500��6,    �� View 5$      �� 5%      .P�5'      ��  �� Width$	 240��6)   $��Question��65    �� CellTemplate 5(      �� 5)   "   .R�5*   &   �� $
��Wrap=�6J   ��60   �� *
Question+6J   5+   #   5-      �� 50      $	 130��6)   $��Answer1��65    51      �� 52   "   .R�53   &   �� $
��Wrap=�6I   ��60   �� *	Answer1+6I   54   #   56      �� 57      $	 130��6)   $��Answer2��65    58      �� 59   "   .R�5:   &   �� $
��Wrap=�6I   ��60   �� *	Answer2+6I   5;   #   5=      �� 5>      $	 130��6)   $��Answer3��65    5?      �� 5@   "   .R�5A   &   �� $
��Wrap=�6I   ��60   �� *	Answer3+6I   5B   #   5D      �� 5E      $	 130��6)   $��Answer4��65    5F      �� 5G   "   .R�5H   &   �� $
��Wrap=�6I   ��60   �� *	Answer4+6I   5I   #   5K      �� 5N      $
 Auto��6)   $��Image��66    5O      �� 5P   "   .R�5Q   &   �� $	��155��6E   $	��100��6Q   ��6,   �� *Image+6Q   5R   #   5T      �� 5W      $	 103��6)   $��Correct Answer��65    5X      �� 5Y   "   .R�5Z   &   �� $��Center=�60    �� TextAlignment$ Center=�6l   $
��Wrap=�6�   ��6M   �� *CorrectAnswer+6�   5[   #   5]      �� 5^      $	 103��6)   $��Your Answer��65    5_      �� 5`   "   .R�5a   &   �� $��Center=�60   $ Center=�6j   $
��Wrap=�6�   ��6N   �� *
YourAnswer+6�   5b   #   5d      5e      5g      �� 5j      -   5        $
 btnback��5j   C   $��Right=�6   $
��Bold"�61   
���  ��$��20q�6e   ���	#FF564B4B$��20(�6�   $	��130��6�   $��40��6�   $
��Back��6�   6�   5k      5l      5m      