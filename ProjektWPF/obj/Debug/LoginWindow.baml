   M S B A M L   `   `   `  ����  
ProjektWPF    ProjektWPF.LoginWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   [ WMahApps.Metro.IconPacks.Material, Version=2.3.0.4, Culture=neutral, PublicKeyToken=null=	iconPacks-http://metro.mahapps.com/winfx/xaml/iconpacks  5   	   -   5          � Title$  
MainWindow��5   	   $	��450��6   $	��380��6)    � WindowStyle$
 None=�5	       � 
ResizeMode$ NoResize=�6    � Triggers 5
      :� 5       :� RoutedEvent$ Window.Loaded��6   [�5      �� 5      .��5      ��  g� RepeatBehavior$ Forever��6    g� AutoReverse . .��5      ��  �� 
TargetName$ 
mainBorder��6    �� TargetProperty$U O(Border.Background).(LinearGradientBrush.GradientStops)[0].(GradientStop.Color)�5      	 �� From$	 DarkBlueX�5      	
 �� To$
 HotPinkX�6-    g� Duration$ 0:0:5D�6:   �� 5      $ 
mainBorder��6   $U O(Border.Background).(LinearGradientBrush.GradientStops)[1].(GradientStop.Color)�5      $	 HotPinkX�5      $
 
DarkVioletX�6.   $ 0:0:5D�6>   �� 5      $ 
mainBorder��6   $U O(Border.Background).(LinearGradientBrush.GradientStops)[2].(GradientStop.Color)�5      $	 
DarkVioletX�5      $
 DarkBlueX�61   $ 0:0:5D�6?   5      5      5      .��5      �  � RowDefinitions 5      �� 5       �� 5!      .+�5#      �� -   5        $��
mainBorder��5#       �� CornerRadius$ 10��6   $��2��6/   ��5$      �� 5%      .��5&      �  � Color$ DarkBlue��6    � Offset$	 0.0Q�6%   � 5'      $ HotPink��6   $
 0.40Q�6$   � 5(      $ 
DarkViolet��6   $	 1.0Q�6'   5)      5+      �� 5-   
   $��0,5,5,0q�6   $��Right=�6'   .+�5.      �� -   5         ��Name$ 
ExitButton��5.      $��40��6B   $��40��6M   $��X��6Y   5/      �� 50   
   $��Center=�6   .+�51      ��  �� Orientation$ 
Horizontal=�6   $��Center=�62   .+�52      �� $��/writing.png��6   $��80��6.   �� 53      $��/cinema.png��6   $��80��6-   55      �� 56      $��Movie Enthusiast Notebook��6   $
��Bold"�69   $��	helvetica)�6K   $��25(�57   	   
�������$��Center=�6+    �� Padding$ 0,20,0,0q�6H   6]   �� 58      $��Login��6   $
��Bold"�6%   $��	helvetica)�67   $��25(�59   	   
�������$��Center=�6+   $ 0,20,0,0q�6H   6]   5:      �� 5<   
   $��1��6   .+�5>      �� $ 
Horizontal=�6   .+�5?      �� -   5         ��Name$ UsernameTextBox��5?      $��	helvetica)�63   $��Light"�6J   $��Username��6]   $��20(�6m   $
��Left=�6{   
�������
������ $��0q�5@   4   $	��235��6H   $��25��6T   $
��Left=�5A       J� Opacity$	 0.7Q�6*   $��62,0,0,0q�68   6L   .  (MahApps.Metro.IconPacks.PackIconMaterial  5B      E AControlzEx, Version=3.0.2.4, Culture=neutral, PublicKeyToken=null�  �ControlzEx.PackIconBase`1[[MahApps.Metro.IconPacks.PackIconMaterialKind, MahApps.Metro.IconPacks.Material, Version=2.3.0.4, Culture=neutral, PublicKeyToken=null]]   Kind$ Account=�6!   $��Center=�61   $��Center=�6L   
�������5C   )   5D      �� 5E      $	��250��6   $��2��6   
�������$	 0.7Q�66   �� 5G      $ 
Horizontal=�6   $��0,20,0,0q�62   .+�5H      G� -   5         G�Name$ PasswordPasswordBox��5H      $��	helvetica)�6;   $��Light"�6R    G� Password$ Password��6e   $��20(�6y   $
��Left=�6�   
�������
������ $��0q�5I   4   $	��235��6H   $��25��6T   $
��Left=�5J      $	 0.7Q�6*   $��62,0,0,0q�68   6L     5K      $ TextboxPassword=�6-   $��Center=�6E   $��Center=�6`   
�������5L   )   5M      �� 5N      $	��250��6   $��2��6!   
�������$	 0.7Q�6?   �� 5P      $ 
Horizontal=�6   $��0,50,0,0q�62   .+�5Q      �� -   5        $ LoginButton��5Q      $	��100��6H   $��40��6T   $��Login��6`   $��	57,0,60,0q�6p   �� 5R      -   5        $ RegisterButton��5R      $	��100��6N   $��40��6Z   $��Register��6f   5S      �� 5T      $��0,20,0,0q�6   $��Center=�6,   .+�5U      �� -   5         ��Name$ AlertTextBlock��5U      $��	helvetica)�64   $
��Bold"�6K   $�� ��6]   $��20(�6e   $��Center=�6s    �� TextAlignment$ Center=�5V      
�������
������ $��25��6L   $	 0.7Q�6X   5W      5X      5Y      5Z      