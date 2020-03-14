import pickle

#Data untuk di serialize && desirialize
bus = {'ID':101, 'Name':"Daihatsu", 'tahun':1998}

#Serialize Object
serialize_bus = pickle.dumps(bus)
print(serialize_bus)
print("Serialize Object Done")

#Deserilaize Object
desirialize_bus = pickle.loads(serialize_bus)
print(desirialize_bus)
print("Deserialize Object Done")