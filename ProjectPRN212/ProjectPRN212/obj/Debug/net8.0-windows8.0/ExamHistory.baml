   M S B A M L   `   `   `  ����H  DProjectPRN212, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:ProjectPRN212ProjectPRN212  5   	       ProjectPRN212.ExamHistory   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:ProjectPRN212     5   	   _ [MaterialDesignThemes.Wpf, Version=5.1.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        � WindowStartupLocation$  CenterScreen=�5       � WindowStyle$
 None=�6B    � AllowsTransparency$
 True��6U    � Title$ ExamHistory��5	      $	��530��6   $	��500��6&   .��5
      � .+�5   
   �� .+�5      (  "MaterialDesignThemes.Wpf.ColorZone     Mode$ PrimaryLight=�6'   .��5      ]� .+�5      �� $��Right=�6!    �� Orientation$ 
Horizontal=�68   
������  � 	Resources 5       �� 
TargetType �� Property	 �� Value��%�   '��       �� 5      " ��6$   .�5   "   ��  � ��$	 2 4 2 4q�6;   6M   �� 5   "    � ��$	 40��6:   6G   5      5      .+�5      �� -   5        
 ��Name$
 btnClose��5   0    � ToolTip$ Đóng��6!    c� OverflowMode$ AsNeeded=�6B   
��� E��.��5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ WindowClose=�66   5      5      �� 5      $ 
Horizontal=�6!   $
��Left=�6:   .+�5      �� $��16,0,0,0q�6$   $��Center=�66   $��Exam History��6Q   $��17(�6e   5      5      5      �� 5      $	��500��6   $G��AD:\Desktop\NET\ProjectPRN212\ProjectPRN212\PRN212\ExamHistory.png��6    �� 5       -   5         ��Name$ QuestionsListView��5    $   $	��260��6   $��Stretch=�6?    �� View 5!      �� 5"      .P�5#      �� $��	Exam Time��6)    �� Width$	 220��6<    �� DisplayMemberBinding 6H   �� *
ExamTime+�� 5$      $��
Exam Score��6)   $	 143��6=    6I   �� *Score+�� 5%      $
��View��6)   $	 107��67    �� CellTemplate 5&      �� 5'   "   .R�5(   &   �� -   5        $
��View��5(   -   
 � Tag 6<   �� *ExamHistoryId+6Z   5)   #   5+      5,      5.      �� 5/      -   5        $
 btnback��5/   C   $��Right=�6   $
��Bold"�61   
���  ��$��20q�6e   ���	#FF564B4B$��20(�6�   $	��130��6�   $��40��6�   $
��Back��6�   6�   50      52      53      