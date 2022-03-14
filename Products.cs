using System;
namespace demos{
    class Product{
        public string _name ;
        public string _type ;
        public int _quantity;
        public int _price ;

        public Product(){
            
        }
        public Product(string name,int price ,int quantity ,string type){
            this._name = name;
            this._type = type;
            this._quantity = quantity;
            this._price = price;
        }

    }
}