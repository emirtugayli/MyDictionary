using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionaryHomework
{
    class MyDictionary<TKey, TValue>
    {
        private TKey[] _key;
        private TKey[] _tempKey;
        private TValue[] _value;
        private TValue[] _tempValue;


        //Constructor olusturdum.
        public MyDictionary()
        {
            _key = new TKey[0];
            _value = new TValue[0];
        }

        public void Add(TKey key, TValue value)
        {
            //Keyleri Temp Arraydan Main Arraya geri aktariyoruz
            _tempKey = _key;
            _key = new TKey[_key.Length + 1];
            for (int i = 0; i < _tempKey.Length; i++)
            {
                _key[i] = _tempKey[i];
            }


            //Valueleri Temp Arrayden Main Arraya Geri Aktariyoruz.
            _tempValue = _value;
            _value = new TValue[_value.Length + 1];
            for (int i = 0; i < _tempValue.Length; i++)
            {
                _value[i] = _tempValue[i];
            }

            _key[_key.Length - 1] = key;
            _value[_value.Length - 1] = value;
        }

        public int Count()
        {
            return _key.Length;
        }

        public TKey GetKey(int index)
        {
            return _key[index];
        }

        public TValue GetValue(int index)
        {
            return _value[index];
        }
        public TValue GetValueByKey(TKey key)
        {
            for (int i = 0; i < _key.Length; i++)
            {
                if (key.Equals(_key[i]))
                {
                    return _value[i];
                }
            }
            throw new Exception("Boyle bir key(Ogrenci No) bulunmamaktadir.");
        }

        public TKey GetKeyByValue(TValue value)
        {
            for (int i = 0; i < _value.Length; i++)
            {
                if (value.Equals(_value[i]))
                {
                    return _key[i];
                }
            }
            throw new Exception("Boyle bir value(ogrenci ismi) bulunmamaktadir.");
        }

    }
}
