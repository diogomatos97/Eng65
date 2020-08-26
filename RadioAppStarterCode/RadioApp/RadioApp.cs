using System;

namespace RadioApp
{
    public class Radio
    {
        private int _channel = 1;
        private bool _on = false;

        public int Channel
        {
            get { return _channel; }
            set { if (_on == true & value > 0 & value <=4) _channel = value; }
        }

        public string Play() {
            if (_on == false)
            {
                return "Radio is off";
            }
            else
            {
                
                  return $"Playing channel {Channel}";
                
            }

        }
        public void TurnOff()
        {
            if (_on == true)
            {
                _on = false;
              
            }

        }
        public void TurnOn() {
            if (_on == false)
            {
                _on = true;
            }
        
        }

        public string ChannelOn(int num)
        {
            switch (num)
            {
                case 2:
                    _channel = num;
                    return "http://bbcmedia.ic.llnwd.net/stream/bbcmedia_radio2_mf_p";

                case 4:
                    _channel = num;
                    return "http://bbcmedia.ic.llnwd.net/stream/bbcmedia_radio1xtra_mf_p";
                case 1:
                    _channel = num;
                    return "http://bbcmedia.ic.llnwd.net/stream/bbcmedia_radio1_mf_p";
                case 3:
                    _channel = num;
                    return "http://bbcmedia.ic.llnwd.net/stream/bbcmedia_radio3_mf_p";
            }
            return "";
        }
        public string Name(int num)
        {
            switch (num)
            {
                case 1:
                    return "BBC Radio 1";
                case 2:
                    return "BBC Radio 2";
                case 3:
                    return "BBC Radio 3";
                case 4:
                    return "BBC 1Xtra";
            }
            return "";
        }

    }
    // implement a class Radio that corresponds to the Class diagram 
    //   and specification in the Radio_Mini_Project document
}