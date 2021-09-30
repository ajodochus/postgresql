:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
:: neue UserControl erstellen, bzw. neue Oberfl�che
:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::



1) in den Visual studio Optionen unter "Windows Forms-Designer / Allgemein / Toolbox" den Wert f�r "Toolbox automatisch auff�llen" auf true setzen, damit die UserControls nach einem Rebuild auch in der Toolbox erscheinen
2) ein neues .net Klassenbibliothek DLL(!!!) Projekt anlegen
3) in diesem Projekt ein neues Benutzersteuerungselement hinzuf�gen (Projekt / Benutzersteuerelement hinzuf�gen)
4) im usercode des Benutzersteuerelement ein Feld f�r die Instanz anlegen, z.B:

 private static rgb_slider _instance;

        public static rgb_slider Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new rgb_slider();
                }
                return _instance;
            }
        }

5) in der WinForm den Aufruf der Instanz hinzuf�gen z.B
(eventuell das Usercontrol aus der Toolbox auf die WinForm ziehen und wieder l�schen. Danach ist sie mit autocomplete-code erreichbar)

private void btn_system_datetime_Click(object sender, EventArgs e)
        {
            if (!panel.Controls.Contains(Usercontrol_datetime.Usercontrol_datetime.Instance))
            {
                panel.Controls.Add(Usercontrol_datetime.Usercontrol_datetime.Instance);
                Usercontrol_datetime.Usercontrol_datetime.Instance.Dock = DockStyle.Fill;
                Usercontrol_datetime.Usercontrol_datetime.Instance.BringToFront();
            }
            else
            {
                Usercontrol_datetime.Usercontrol_datetime.Instance.BringToFront();
            }
        }

