   M S B A M L   `   `   `  ����I  EBankWindowsWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:BankWindowsWPFBankWindowsWPF  5   	   o<clr-namespace:BankWindowsWPF.ServiceReferenceToDataBaseBank2.BankWindowsWPF.ServiceReferenceToDataBaseBank2  5   	       BankWindowsWPF.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:BankWindowsWPF     5   	   hServiceReferenceToDataBaseBank2<clr-namespace:BankWindowsWPF.ServiceReferenceToDataBaseBank2     5   	     � Title$  
MainWindow��5	   	   $	��585��6   $
��1121��6)   .��5
      � .+�5   
   �� -   5         ��Name$ 
NrAccount2��5      $��	NrAccount��6$   $
��Left=�68   $��	10,10,0,0q�6S   $	��Top=�6f   �� 5   
   -   5        $ 	FirstName��5      $��	FirstName��6#   $
��Left=�67   $��	10,36,0,0q�6R   $	��Top=�6e   �� 5   
   -   5        $ LastName��5      $��LastName��6"   $
��Left=�65   $��	10,62,0,0q�6P   $	��Top=�6c   �� 5   
   -   5        $
 City��5      $
��City��6   $
��Left=�6-   $��	10,88,0,0q�6H   $	��Top=�6[   �� 5   
   -   5        $ Street��5      $��Street��6    $
��Left=�61   $��
10,114,0,0q�6L   $	��Top=�6`   �� 5   
   -   5        $ NrHouse��5      $��NrHouse��6!   $
��Left=�63   $��
10,140,0,0q�6N   $	��Top=�6b   �� 5   
   -   5        $ PostCode��5      $��PostCode��6"   $
��Left=�65   $��
10,166,0,0q�6P   $	��Top=�6d   �� 5   
   -   5        $ AccountBalance��5      $��AccountBalance��6(   $
��Left=�6A   $��
10,192,0,0q�6\   $	��Top=�6p   �� 5   
   $
��Left=�6   $��23��6-   $��
109,13,0,0q�69    �� TextWrapping$
 Wrap=�6M   $��TextBox��6a   $	��Top=�6p   $	��120��6�   {�.  6�   �� 5   
   -	   5         ��Name$ TextBoxFirstName��5      $
��Left=�6,   $��23��6G   $��
109,39,0,0q�6S   $
 Wrap=�6g   $��	FirstName��6{   $	��Top=�6�   $	��120��6�   �� 5   
   -
   5        $ TextBoxLastName��5      $
��Left=�6+   $��23��6F   $��
109,65,0,0q�6R   $
 Wrap=�6f   $��TextBox��6z   $	��Top=�6�   $	��120��6�   �� 5   
   -   5        $ TextBoxCity��5      $
��Left=�6'   $��23��6B   $��
109,91,0,0q�6N   $
 Wrap=�6b   $��TextBox��6v   $	��Top=�6�   $	��120��6�   �� 5   
   -   5        $ TextBoxStreet��5      $
��Left=�6)   $��23��6D   $��109,114,0,0q�6P   $
 Wrap=�6e   $��TextBox��6y   $	��Top=�6�   $	��120��6�   �� 5   
   -   5        $ TextBoxNrHouse��5      $
��Left=�6*   $��23��6E   $��109,140,0,0q�6Q   $
 Wrap=�6f   $��TextBox��6z   $	��Top=�6�   $	��120��6�   �� 5   
   -   5        $ TextBoxPostCode��5      $
��Left=�6+   $��23��6F   $��109,166,0,0q�6R   $
 Wrap=�6g   $��TextBox��6{   $	��Top=�6�   $	��120��6�   �� 5   
   -   5        $ TextBoxAccountBallance��5      $
��Left=�62   $��23��6M   $��109,192,0,0q�6Y   $
 Wrap=�6n   $��TextBox��6�   $	��Top=�6�   $	��120��6�   �� 5   
   -   5         ��Name$ SendData��5      $��	Send Data��6#   $
��Left=�67   $��125,225,0,0q�6R   $	��Top=�6g   $��75��6   6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ DataGridAccount��5         AutoGenerateColumns . $
��Left=�6G   $	��294��6b   $��
10,250,0,0q�6o   $	��Top=�6�   $	��600��6�   6�     5   
   -   5        $ DataGridOperation��5      $
��Left=�6.   $	��531��6I   $��
821,13,0,0q�6V   $	��Top=�6j   $	��282��6�   �� 5   
   -   5        $ LabelAmount��5      $��Amount:��6%   $
��Left=�67   $��
576,65,0,0q�6R   $	��Top=�6f   �� 5   
   -   5        $ 	LabelDate��5      $
��Date��6#   $
��Left=�62   $��576,114,0,0q�6M   $	��Top=�6b    J� RenderTransformOrigin$ 0.789,0.269&�6z   (  "System.Windows.Controls.DatePicker  5    
   -   5          Name$ DateOperation��5       $
��Left=�6,   $��673,114,0,0q�6G   $	��Top=�6\   �� 5!   
   -   5        $ TextBoxOperationAmount��5!      $
��Left=�62   $��23��6M   $��
673,68,0,0q�6Y   $
 Wrap=�6m   $��TextBox��6�   $	��Top=�6�   $	��120��6�   �� 5"   
   -   5        $ ButtonSaveOperation��5"      $��Zapisz operacje��6.   $
��Left=�6H   $��673,166,0,0q�6c   $	��Top=�6x   $��75��6�   6�   5$      5%      