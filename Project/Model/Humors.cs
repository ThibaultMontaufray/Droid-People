using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Droid.People
{
    public class Humors
    {
        #region Enum
        public enum DatabaseIndex
        {
            insouciance = 1,
            colere = 2,
            complicite = 3,
            gene = 4,
            joie = 5,
            concentration = 6,
            taquinerie = 7,
            curiosite = 8,
            tristesse = 9,
            etonnement = 10,
            fatigue = 11,
            mecontentement = 12,
            empathie = 13
        }
        #endregion

        #region Attribute
        private int _insouciance;
        private int _colere;
        private int _complicite;
        private int _gene;
        private int _joie;
        private int _concentration;
        private int _taquinerie;
        private int _curiosite;
        private int _tristesse;
        private int _etonnement;
        private int _fatigue;
        private int _mecontentement;
        private int _empathie;
        #endregion

        #region Properties
        public int Empathie
        {
            get { return _empathie; }
            set { _empathie = value; }
        }
        public int Mecontentement
        {
            get { return _mecontentement; }
            set { _mecontentement = value; }
        }
        public int Fatigue
        {
            get { return _fatigue; }
            set { _fatigue = value; }
        }
        public int Etonnement
        {
            get { return _etonnement; }
            set { _etonnement = value; }
        }
        public int Tristesse
        {
            get { return _tristesse; }
            set { _tristesse = value; }
        }
        public int Curiosite
        {
            get { return _curiosite; }
            set { _curiosite = value; }
        }
        public int Taquinerie
        {
            get { return _taquinerie; }
            set { _taquinerie = value; }
        }
        public int Concentration
        {
            get { return _concentration; }
            set { _concentration = value; }
        }
        public int Joie
        {
            get { return _joie; }
            set { _joie = value; }
        }
        public int Gene
        {
            get { return _gene; }
            set { _gene = value; }
        }
        public int Complicite
        {
            get { return _complicite; }
            set { _complicite = value; }
        }
        public int Colere
        {
            get { return _colere; }
            set { _colere = value; }
        }
        public int Insouciance
        {
            get { return _insouciance; }
            set { _insouciance = value; }
        }
        #endregion

        #region Constructor
        public Humors()
        {
            Clear();
        }
        #endregion

        #region Methods public
        public void Update(List<string[]> dumpDataBase)
        {
            Clear();
            foreach (var row in dumpDataBase)
            {
                AddRow(row);
            }
        }
        #endregion

        #region Methods private
        private void Clear()
        {
            foreach (FieldInfo field in typeof(Humors).GetFields())
            {
                field.SetValue(this, 0);
            }
        }
        private void AddRow(string[] row)
        {
            if (row.Length > 12) { return; }
            else
            {
                _colere += int.Parse(row[(int)DatabaseIndex.colere]);
                _complicite += int.Parse(row[(int)DatabaseIndex.complicite]);
                _concentration += int.Parse(row[(int)DatabaseIndex.concentration]);
                _curiosite += int.Parse(row[(int)DatabaseIndex.curiosite]);
                _empathie += int.Parse(row[(int)DatabaseIndex.empathie]);
                _etonnement += int.Parse(row[(int)DatabaseIndex.etonnement]);
                _fatigue += int.Parse(row[(int)DatabaseIndex.fatigue]);
                _gene += int.Parse(row[(int)DatabaseIndex.gene]);
                _insouciance += int.Parse(row[(int)DatabaseIndex.insouciance]);
                _joie += int.Parse(row[(int)DatabaseIndex.joie]);
                _mecontentement += int.Parse(row[(int)DatabaseIndex.mecontentement]);
                _taquinerie += int.Parse(row[(int)DatabaseIndex.taquinerie]);
                _tristesse += int.Parse(row[(int)DatabaseIndex.tristesse]);
            }
        }
        #endregion
    }
}
