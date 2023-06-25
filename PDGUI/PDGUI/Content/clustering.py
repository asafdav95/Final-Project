import matplotlib.pyplot as plt
import pandas as pd
from sklearn.manifold import TSNE
from sklearn.cluster import SpectralClustering



def Good_spectral_cluster(data):
    #tsne = TSNE(n_components=3, random_state=1)
    tsne = TSNE(n_components=2, perplexity=30.0, early_exaggeration=12.0, learning_rate='auto',
            n_iter=1000, n_iter_without_progress=300, min_grad_norm=1e-07, metric='euclidean',
            init='pca', verbose=0, random_state=None, method='barnes_hut',
            angle=0.5, n_jobs=None, square_distances=True)    
    tsne_data = tsne.fit_transform(data)
    
    spectral = SpectralClustering(n_clusters=2)
    clusters = spectral.fit_predict(tsne_data)
    
    plt.scatter(tsne_data[:, 0], tsne_data[:, 1], c=clusters)
    plt.title('Spectral Clustering')
    plt.xlabel('TSNE Dimension 1')
    plt.ylabel('TSNE Dimension 2')
    plt.show()
    
    return clusters


def spectral_cluster(data):
    #tsne = TSNE(n_components=3, random_state=1)
    tsne = TSNE(n_components=2, perplexity=15.0, early_exaggeration=12.0, learning_rate='auto',
            n_iter=1000, n_iter_without_progress=300, min_grad_norm=1e-07, metric='euclidean',
            init='pca', verbose=0, random_state=None, method='barnes_hut',
            angle=0.5, n_jobs=None, square_distances=True)    
    tsne_data = tsne.fit_transform(data)
    
    spectral = SpectralClustering(n_clusters=2)
    clusters = spectral.fit_predict(tsne_data)
    
    plt.scatter(tsne_data[:, 0], tsne_data[:, 1], c=clusters)
    plt.title('Spectral Clustering')
    plt.xlabel('TSNE Dimension 1')
    plt.ylabel('TSNE Dimension 2')
    plt.savefig('plot.jpg', format='jpeg')
    plt.show()
    
    
    return clusters

def get_final_lists_from_clusters(clusters, only_names):
    ones = []
    zeroes = []
    
    for i, value in enumerate(clusters):
        if value == 1:
            ones.append(i)
        elif value == 0:
            zeroes.append(i)
    
        
    cluster1 = []
    for index in ones:
        cluster1.append(only_names.iloc[index,0])
    
    cluster2 = []
    for index in zeroes:
        cluster2.append(only_names.iloc[index,0])
    
    return cluster1, cluster2


data = pd.read_excel("res_reportA16.xlsx", sheet_name="res_report89500")
only_data = data.iloc[:, 1:]
only_names = data.iloc[:, 0:1]

clusters = spectral_cluster(only_data)

cluster1, cluster2 = get_final_lists_from_clusters(clusters, only_names)

with open('cluster1.txt', 'w') as file:
    for value in cluster1:
        file.write(value + '\n')  
        
with open('cluster2.txt', 'w') as file:
    for value in cluster2:
        file.write(value + '\n')        
        