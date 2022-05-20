import xml.etree.ElementTree as ET

tree = ET.parse('xml.xml')
root = tree.getroot()

for country in root.findall('country'):
    rank = country.find('rank').text
    name = country.get('name')
    print(name, rank)
    
    
for rank in root.findall('./test/rank'):
    new_rank = int(rank.text) + 1
    rank.text = str(new_rank)
    rank.set('updated', 'yes')


for test in root.findall('test_remove'):
    rank = int(test.find('rank').text)
    print(rank)
    if rank > 10:
        root.remove(test)


tree.write('xml.xml') 

