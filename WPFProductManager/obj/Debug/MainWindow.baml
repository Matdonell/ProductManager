   M S B A M L   `   `   `  ����L  HWPFProductManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:WPFProductManager.ViewsWPFProductManager.Views  5   	   #    WPFProductManager.MainWindows   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4my%clr-namespace:WPFProductManager.Views     5   	     � Title$  Product Manager��5   	   $	��500��6!   $	��600��6.   $	��800��6:   $	��430��6I   .��5      ]� .+�5
   
   �� $	��Top=�6   $��25��6*   
����  �.+�5      �� $��14(�6   $��Center=�6&   $��Center=�6C   
�������$��Fiche produit��6q   5      � 5   
   
�������$��0,1,0,-1q�6&    � ColumnDefinitions 5      �� 5      $��* �6#   $	��300��6-   �� 5      $��2* �6#   .+�5      � $
��Left=�6   $	��150��6)   $
��Auto��68   $��0��6F    � RowDefinitions 5      �� 5      $
��Auto �6$   �� 5      $��* �6$   �� 5      $
��Auto �6$   .+�5      �� $��14(�6   $��19��6*   $	��Top=�66   �� 6O   $�Liste de��6S   �� 6e   $� ��6i   �� 6t   $�produits��6x   6�   *   $WPFProductManager.Views.ListeProduit  5      $��1��6"   $��0,0,-516,10q�6]    � DataContext 6/   �� *ListeProduitViewModel+6]   5      5      5      5!      