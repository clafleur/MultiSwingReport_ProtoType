   M S B A M L   `   `   `  ����U  QMultiSwingReport_ProtoType, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:MultiSwingReport_ProtoType.ViewMultiSwingReport_ProtoType.View  5      q mSoftwareArchitects.Windows.Controls.ScrollSynchronizer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null�qclr-namespace:SoftwareArchitects.Windows.Controls;assembly=SoftwareArchitects.Windows.Controls.ScrollSynchronizer#SoftwareArchitects.Windows.Controls 5	      6    0MultiSwingReport_ProtoType.View.MultiSwingReport   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ?local-clr-namespace:MultiSwingReport_ProtoType.View     5      U QMaterialDesignThemes.Wpf, Version=2.3.1.953, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5      ~scrollqclr-namespace:SoftwareArchitects.Windows.Controls;assembly=SoftwareArchitects.Windows.Controls.ScrollSynchronizer  5	        � 	Resources  5         MaterialDesignDataGridCell �� BasedOn*  $System.Windows.Controls.DataGridCell �� 
TargetType �� Property �� Value��%m   '        7   �� 5   
   8   "  6F   .�5      ��  �@��TextAlignment$ Center=�68   5      5      .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      .+�5   
   �� $��	12,12,0,0q�5      $
��Left=�5        KVestLogoColorBrush#��[ 5      $��1q�5       �� CornerRadius$ 5��5      ._�5      �� $��10q�6    �� Orientation$ Vertical=�6%   .+�5      �� $��0,0,0,10q�5       $��Center=�5!       % !MaterialDesignSubheadingTextBlock#���  5"      $��Number of Swings to Load��5#      �� 5$      $ 
Horizontal=�6   .+�5%      	� -   5         	�Name$ LastFiveRadioButton��5&      $��	12,0,12,0q�5'      $��Center=�5(      $��Last 5��5*      $��15(�5+      	� 5,      -   5        $��0,0,12,0q�5-      $��Center=�5.      $��Last 10��50      $��15(�51      	� 52      -   5        $��0,0,12,0q�53      $��Center=�54      $��Last 15��56      $��15(�57      	� 58      -   5        $��0,0,12,0q�59      $��Center=�5:      $	��All��5<      $��15(�5=      5>      5?      5@      �� 5A   
   $��1��5B      $��10q�5C      $
��Auto=�5D      $��Disabled=�5E      .��5G      � 	 � ColumnDefinitions	 5H      �� 5I      �� 5J      �� 5K      �� 5L      $
��Auto �6'   .+�5N      ?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase
   OpeningEffectsOffset
 66   O  IMaterialDesignThemes.Wpf.Transitions.IndexedItemOffsetMultiplierExtension  *	0:0:0.7+   OpeningEffects 5O      ;  5MaterialDesignThemes.Wpf.Transitions.TransitionEffect  5P         Kind$ FadeIn=�6:      Duration$ 0:0:0.75h�6H     5Q      $ SlideInFromLeft=�6:   $ 0:0:0.5h�6Q   .��5S      #  MaterialDesignThemes.Wpf.Card  $	��300��6*   $��
2,10,10,10q�6:   .��5T      �  5U      �� 5V   "   $
��Auto �60   �� 5W   "   $
��Auto �60   �� 5X   "   	 5Z      �� 5[   "   �� 5\   "   .+�5^      �� $��2��6(   #��[ 6<   �� 5_      $��2��5`   !   $
��0,10q�5a   !   $��Center=�5b   !   $��Center=�5c   !   $
��Bold"�5d   !   
�������   MaterialDesignTitleTextBlock#���  5f   !   $��ADDRESS��5g   !   �� 5h      $��1��5i   !   $��0,8,0,0q�5j   !   $��Center=�5k   !   #���  5l   !   $��Pelvis��5m   !   �� 5n      $��1��5o   !   $��1��5p   !   $��0,8,0,0q�5q   !   $��Center=�5r   !   #���  5s   !   $��Torso��5t   !   �� 5v      $��2��5w   !   $��2��5x   !   $��
10,0,10,10q�5y   !   <  6SoftwareArchitects.Windows.Controls.ScrollSynchronizer   ScrollGroup$ Group1��5z   !   $��Hidden=�5{   !   .��5|   "   � $��2��6'   $��2��64   	 5}   &   �� 5~   *   �� 5   *   .+�5�   &   &   System.Windows.Controls.DataGrid  -   5          Name$ AddressPelvisDataGrid��5�   )   $��0,0,12,0q�5�   )   $��Center=�5�   )      AutoGenerateColumns .  
������    CanUserAddRows .   J� IsHitTestVisible .  "   VerticalScrollBarVisibility$ Hidden=�5�   )      Columns 5�   *   0	  *System.Windows.Controls.DataGridTextColumn	  5�   .   ,
  &System.Windows.Controls.DataGridColumn 
  Header$
 Turn��6k   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6A   �� *Turn+ �� StringFormat$ N2��6k   	  5�   .   $
 Bend��6k    6A   �� *Bend+$ N2��6k   	  5�   .   $ 	Side Bend��6o    6A   �� *
SideBend+$ N2��6o   5�   '     5�   &   -   5        $ AddressTorsoDataGrid��5�   )   $��1��5�   )   $��Center=�5�   )    .  
������  .   .  $
 Auto=�5�   )    5�   *   	  5�   .   $
 Turn��6k    6A   �� *Turn+$ N2��6k   	  5�   .   $
 Bend��6k    6A   �� *Bend+$ N2��6k   	  5�   .   $ 	Side Bend��6o    6A   �� *
SideBend+$ N2��6o   5�   '   5�   #   5�      5�      5�      5�        5�      $��1��66   
 6F     *	0:0:0.7+ 5�        5�      $ FadeIn=�6:   $ 0:0:1h�6H     5�      $ SlideInFromLeft=�6:   $ 0:0:0.75h�6Q   .��5�        $	��300��6*   $��
2,10,10,10q�6:   .��5�      �  5�      �� 5�   "   $
��Auto �60   �� 5�   "   $
��Auto �60   �� 5�   "   	 5�      �� 5�   "   �� 5�   "   .+�5�      �� $��2��6(   #��[ 6<   �� 5�      $��2��5�   !   $
��0,10q�5�   !   $��Center=�5�   !   $
��Bold"�5�   !   
�������#���  5�   !   $	��TOP��5�   !   �� 5�      $��1��5�   !   $��0,8,0,0q�5�   !   $��Center=�5�   !   #���  5�   !   $��Pelvis��5�   !   �� 5�      $��1��5�   !   $��1��5�   !   $��0,8,0,0q�5�   !   $��Center=�5�   !   #���  5�   !   $��Torso��5�   !   �� 5�      $��2��5�   !   $��2��5�   !   $��
10,0,10,10q�5�   !   $ Group1��5�   !   $��Hidden=�5�   !   .��5�   "   � 	 5�   &   �� 5�   *   �� 5�   *   .+�5�   &     -   5        $ TopPelvisDataGrid��5�   )   $��0,0,12,0q�5�   )   $��Center=�5�   )    .  
������  .   .  $ Hidden=�5�   )    5�   *   	  5�   .   $
 Turn��6k    6A   �� *Turn+$ N2��6k   	  5�   .   $
 Bend��6k    6A   �� *Bend+$ N2��6k   	  5�   .   $ 	Side Bend��6o    6A   �� *
SideBend+$ N2��6o   5�   '     5�   &   -   5        $ TopTorsoDataGrid��5�   )   $��1��5�   )   $��Center=�5�   )    .  
������  .   .  $ Hidden=�5�   )    5�   *   	  5�   .   $
 Turn��6k    6A   �� *Turn+$ N2��6k   	  5�   .   $
 Bend��6k    6A   �� *Bend+$ N2��6k   	  5�   .   $ 	Side Bend��6o    6A   �� *
SideBend+$ N2��6o   5�   '   5�   #   5�      5�      5�      5�        5�      $��2��66   
 6F     *	0:0:0.7+ 5�        5�      $ FadeIn=�6:   $ 0:0:1.25h�6H     5�      $ SlideInFromLeft=�6:   $ 0:0:1h�6Q   .��5        $	��300��6*   $��	2,10,2,10q�6:   .��5     �  5     �� 5  "   $
��Auto �60   �� 5  "   $
��Auto �60   �� 5  "   	 5     �� 5  "   �� 5	  "   .+�5     �� $��2��6(   #��[ 6<   �� 5     $��2��5  !   $
��0,10q�5  !   $��Center=�5  !   $
��Bold"�5  !   
�������#���  5  !   $��IMPACT��5  !   �� 5     $��1��5  !   $��0,8,0,0q�5  !   $��Center=�5  !   #���  5  !   $��Pelvis��5  !   �� 5     $��1��5  !   $��1��5  !   $��0,8,0,0q�5  !   $��Center=�5  !   #���  5  !   $��Torso��5   !   �� 5!     $��2��5"  !   $��2��5#  !   $��0,0,1,0q�5$  !   $��
10,0,10,10q�5%  !   $ Group1��5&  !   $
��Auto=�5'  !   .��5(  "   � 	 5)  &   �� 5*  *   �� 5+  *   .+�5-  &     -	   5        $ HitPelvisDataGrid��5.  )   $��0,0,12,0q�5/  )   $��Center=�50  )    .  
������  .   .  $ Hidden=�55  )    56  *   	  57  .   $
 Turn��6k    6A   �� *Turn+$ N2��6k   	  58  .   $
 Bend��6k    6A   �� *Bend+$ N2��6k   	  59  .   $ 	Side Bend��6o    6A   �� *
SideBend+$ N2��6o   5;  '     5<  &   -
   5        $ HitTorsoDataGrid��5=  )   $��1��5>  )   $��Center=�5?  )    .  
������  .   .  $ Hidden=�5D  )    5E  *   	  5F  .   $
 Turn��6k    6A   �� *Turn+$ N2��6k   	  5G  .   $
 Bend��6k    6A   �� *Bend+$ N2��6k   	  5H  .   $ 	Side Bend��6o    6A   �� *
SideBend+$ N2��6o   5J  '   5K  #   5M     5N     5O     5P     5Q     5S     5T     5U     