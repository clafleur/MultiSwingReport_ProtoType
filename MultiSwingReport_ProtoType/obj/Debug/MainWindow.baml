   M S B A M L   `   `   `  ����U  QMultiSwingReport_ProtoType, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:MultiSwingReport_ProtoTypeMultiSwingReport_ProtoType  5      Q-clr-namespace:MultiSwingReport_ProtoType.ViewMultiSwingReport_ProtoType.View  5	      +    %MultiSwingReport_ProtoType.MainWindow   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      :local(clr-namespace:MultiSwingReport_ProtoType     5      U QMaterialDesignThemes.Wpf, Version=2.3.1.953, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5      6vm-clr-namespace:MultiSwingReport_ProtoType.View  5	        � Title$  
MainWindow��5
         MaterialDesignPaper#���   5        MaterialDesignFont#���  5        MaterialDesignBody#���  5       � 	Resources 5         BooleanToVisibilityConverter��%   &	       �� 5   
   6'   5      .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      �� 5      $
��Auto �6   .+�5   
   �  � ColumnDefinitions 5      �� 5      $
��Auto �6#   �� 5      �� 5      $
��Auto �6#   .+�5      ��  �� Orientation$ 
Horizontal=�6   y�62   �� *	IsChecked+ �� 	Converter# [  �� ElementName$ Option1��.+�5       �� $��40��5!      $��40��5"      $��10q�5#        KVestLogoColorBrush#��[ 5$       �� CornerRadius$ 30��5%      ._�5&      �� $��Center=�5'      $��Center=�5(      $��20(�5)      
�������$��K��5+      5,      �� 5-      $��Center=�5.         MaterialDesignTitleTextBlock#���  5/      $��	Adam Kmak��50      51      �� 53      $ 
Horizontal=�6   y�62   �� *	IsChecked+# [ $ Option2��.+�54      �� $��40��55      $��40��56      $��10q�57      #��[ 58      $ 30��59      ._�5:      �� $��Center=�5;      $��Center=�5<      $��20(�5=      
�������$��K��5?      5@      �� 5A      -   5         ��Name$ PlayerComboBox��5B      $	��150��5C      $��Center=�5D      $��20(�5E      .@�5F      �� $��	Adam Kmak��6#   	 �� 
IsSelected	 . 67   �� 5G      $��Mason M1��6#   �� 5H      $��Melissa Sweet��6#   �� 5I      $��Teri Dunlop��6#   �� 5J      $��Chris Turner��6#   5K      5L      �� 5M      $��3��5N      $��Bottom=�5O      ���	#FF757575y�5Q      �� *	IsChecked+# [ $ Option1���� 5R      $��3��5S      $��Bottom=�5T      ���	#FF757575y�5V      �� *	IsChecked+# [ $ Option2��5W      � 5X   
   $��1��6   .+�5Y      6   0MultiSwingReport_ProtoType.View.MultiSwingReport  y�6"   �� *	IsChecked+# [ $ Option1��=   7MultiSwingReport_ProtoType.View.Option2MultiSwingReport  5Z      y�6)   �� *	IsChecked+# [ $ Option2��=   7MultiSwingReport_ProtoType.View.Option3MultiSwingReport  5[      y�6)   �� *	IsChecked+# [ $ Option3��5\      �� 5^   
   $��2��5_      $��1��5`      $
��0,15q�5a      $��Center=�5b      $��Center=�5c      $ 
Horizontal=�5d      .+�5e      	� -   5        
 	�Name$
 Option1��5f      $
��20,0q�5g      $��Option 1��5h      	� 5i      -   5        $
 Option2��5i      $��Option 2��6+   	� 5j      -   5        $
 Option3��5j      $��Option 3��6+   $
��20,0q�6>   5k      �� 5l   
   $��2��5m      $��3��5n      $��Right=�5o      $��Center=�5p      $ 
Horizontal=�5q      .+�5r      �� $
��20,0q�6   $��Light��6&   d� 5s      -   5        5s   ?   �� 5t      $
��20,0q�6   $
��Dark��6&   5u      5v      5w      